using Meraki.Api.Extensions;

namespace Meraki.Api;

internal sealed class AuthenticatedBackingOffHttpClientHandler : DelegatingHandler
{
	private readonly MerakiClientOptions _options;
	private readonly MerakiClient _merakiClient;
	private readonly ILogger _logger;
	private readonly LogLevel _levelToLogAt = LogLevel.Trace;

	public AuthenticatedBackingOffHttpClientHandler(
		MerakiClientOptions options,
		MerakiClient merakiClient,
		ILogger logger)
		: this(options, merakiClient, logger, new HttpClientHandler())
	{
	}

	internal AuthenticatedBackingOffHttpClientHandler(
		MerakiClientOptions options,
		MerakiClient merakiClient,
		ILogger logger,
		HttpMessageHandler innerHandler)
	{
		_options = options;
		_merakiClient = merakiClient;
		_logger = logger;
		InnerHandler = innerHandler;
	}

	/// <summary>
	/// Gets the last request uri
	/// </summary>

	public string LastRequestUri { get; private set; } = string.Empty;

	/// <summary>
	/// Gets the statistics
	/// </summary>

	public MerakiClientStatistics Statistics { get; } = new();

	private readonly Stopwatch _durationStopWatch = new();

	protected override async Task<HttpResponseMessage> SendAsync(
		HttpRequestMessage request,
		CancellationToken cancellationToken)
	{
		EnsureRequestIsPermitted(request);
		await PrepareRequestAsync(request, cancellationToken).ConfigureAwait(false);

		var logPrefix = $"Request {Guid.NewGuid()}: ";
		var attemptCount = 0;

		while (true)
		{
			_durationStopWatch.Restart();
			attemptCount++;
			cancellationToken.ThrowIfCancellationRequested();

			await LogRequestAsync(logPrefix, request, cancellationToken).ConfigureAwait(false);

			LastRequestUri = request.RequestUri?.ToString() ?? string.Empty;

			// Create a new CancellationToken derived from the original, but with a timeout
			using var timeoutCancellationSource = new CancellationTokenSource(TimeSpan.FromSeconds(_options.HttpClientInnerTimeoutSeconds));

			// A null response means the attempt failed in a way that has already been logged and waited out.
			var httpResponseMessage = await TrySendAsync(
				request,
				logPrefix,
				attemptCount,
				timeoutCancellationSource.Token,
				cancellationToken)
				.ConfigureAwait(false);
			if (httpResponseMessage is null)
			{
				continue;
			}

			_merakiClient.LastResponseHeaders = httpResponseMessage.Headers;

			await LogResponseAsync(logPrefix, httpResponseMessage, cancellationToken).ConfigureAwait(false);

			// Only record the time we spent processing the request/response
			_durationStopWatch.Stop();

			var delay = TimeSpan.Zero;
			var statusCodeInt = (int)httpResponseMessage.StatusCode;

			try
			{
				// As long as we were not given a back-off request then we'll return the response and any
				// further StatusCode handling is up to the caller.
				if (!TryGetRetryDelay(httpResponseMessage, statusCodeInt, attemptCount, logPrefix, request, out delay))
				{
					return httpResponseMessage;
				}

				// Try up to the maximum retry count.
				if (attemptCount >= _options.MaxAttemptCount)
				{
#pragma warning disable CA1873 // Avoid potentially expensive logging
					_logger.LogInformation(
						"{LogPrefix}Giving up retrying. Returning {StatusCodeInt} on attempt {AttemptCount}/{MaxAttemptCount}. ({Method} - {Url})",
						logPrefix,
						statusCodeInt,
						attemptCount,
						_options.MaxAttemptCount,
						request.Method.ToString(),
						request.RequestUri);
					return httpResponseMessage;
				}

				_logger.LogInformation(
					"{LogPrefix}Received {StatusCode} on attempt {AttemptCount}/{MaxAttemptCount} - Waiting {TotalSeconds:N2}s. ({Method} - {Url})",
					logPrefix,
					statusCodeInt,
					attemptCount,
					_options.MaxAttemptCount,
					delay.TotalSeconds,
					request.Method.ToString(),
					request.RequestUri);
#pragma warning restore CA1873 // Avoid potentially expensive logging

				await Task.Delay(delay, cancellationToken).ConfigureAwait(false);
			}
			finally
			{
				// Record the status code
				Statistics.RecordStatusCode(statusCodeInt, (long)_durationStopWatch.Elapsed.TotalMilliseconds, (long)delay.TotalMilliseconds);
			}
		}
	}

	/// <summary>
	/// Rejects requests that the configured options do not allow to be sent at all.
	/// </summary>
	private void EnsureRequestIsPermitted(HttpRequestMessage request)
	{
		// Simplistic ReadOnly implementation to ensure only reading from the API
		if (_options.ReadOnly && request.Method != HttpMethod.Get)
		{
			throw new InvalidOperationException(Resources.OnlyReadOnlyOperationsPermitted);
		}

		// Ensure authentication is configured
		var hasApiKey = !string.IsNullOrWhiteSpace(_options.ApiKey);
		var hasAccessToken = !string.IsNullOrWhiteSpace(_options.AccessToken);

		if (!hasApiKey && !hasAccessToken)
		{
			throw new InvalidOperationException(Resources.AuthenticationNotConfigured);
		}
	}

	/// <summary>
	/// Applies rate limiting, authentication and the user agent, once, before the first attempt.
	/// </summary>
	private async Task PrepareRequestAsync(HttpRequestMessage request, CancellationToken cancellationToken)
	{
		if (_options.RateLimiter is not null)
		{
			await _options
				.RateLimiter
				.ApplyRateLimitingAsync(
					request,
					cancellationToken)
				.ConfigureAwait(false);
		}

		ApplyAuthentication(request, _options);

		if (_options.UserAgent is not null)
		{
			request.Headers.Add("User-Agent", _options.UserAgent);
		}
	}

	/// <summary>
	/// Makes one attempt, returning null where the failure is transient and a retry is due. Each
	/// retryable failure is logged and waited out here; anything else propagates to the caller.
	/// </summary>
	private async Task<HttpResponseMessage?> TrySendAsync(
		HttpRequestMessage request,
		string logPrefix,
		int attemptCount,
		CancellationToken timeoutToken,
		CancellationToken cancellationToken)
	{
		try
		{
			return await base
				.SendAsync(request, timeoutToken)
				.ConfigureAwait(false);
		}
		// Catch any timeouts from the new cancellationToken
		catch (OperationCanceledException) when (timeoutToken.IsCancellationRequested && !cancellationToken.IsCancellationRequested)
		{
			// This was a timeout from our timeout token, not the original cancellation token
			// So we'll treat this as a timeout and retry
			if (attemptCount >= _options.MaxAttemptCount)
			{
				_logger.LogError(
					"{LogPrefix}Giving up retrying. Timed out after {TimeoutSeconds:N1} seconds on attempt {AttemptCount}/{MaxAttemptCount}. ({Method} - {Url})",
					logPrefix,
					_options.HttpClientInnerTimeoutSeconds,
					attemptCount,
					_options.MaxAttemptCount,
					request.Method.ToString(),
					request.RequestUri
					);
				throw new TimeoutException($"The request timed out after multiple attempts ({_options.MaxAttemptCount}).");
			}

			// Back off before retrying. A timeout usually means the far end is slow because it is
			// under load, so returning immediately is the least helpful response available, and it
			// is the one case where we have already waited HttpClientInnerTimeoutSeconds and so have
			// the least reason to expect the next attempt to be quicker. Every other retry path in
			// this method pauses first.
			//
			// There is no Retry-After to honour here, so pass zero and let the configured back-off
			// factor govern, rather than introducing another magic number.
			var timeoutDelay = ApplyJitter(
				CalculateBackoffDelay(attemptCount, retryAfterSeconds: 0, _options.BackOffDelayFactor, _options.MaxBackOffDelaySeconds),
				_options.MaxBackOffDelaySeconds,
				GetJitterRandom());

			_logger.LogWarning(
				"{LogPrefix}Timed out after {TimeoutSeconds:N1} seconds on attempt {AttemptCount}/{MaxAttemptCount} - Waiting {TotalSeconds:N2}s. ({Method} - {Url})",
				logPrefix,
				_options.HttpClientInnerTimeoutSeconds,
				attemptCount,
				_options.MaxAttemptCount,
				timeoutDelay.TotalSeconds,
				request.Method.ToString(),
				request.RequestUri
				);

			await Task.Delay(timeoutDelay, cancellationToken).ConfigureAwait(false);
			return null;
		}
		// This is a common error that seems to occur when contacting meraki nodes, so we log it as a warning and retry
		catch (HttpRequestException ex) when (ex.Message.StartsWith("Network is unreachable", StringComparison.Ordinal))
		{
			if (attemptCount >= _options.MaxAttemptCount)
			{
				LogGivingUpOnTransientFailure(ex, logPrefix, attemptCount, request, "Network is unreachable");
				throw;
			}

			// Wait 1 second and then retry
			await WaitAfterTransientFailureAsync(
				ex,
				logPrefix,
				attemptCount,
				request,
				"Network is unreachable",
				TimeSpan.FromSeconds(1),
				cancellationToken)
				.ConfigureAwait(false);
			return null;
		}
		// This is a common error that occurs when the remote server (Meraki API) abruptly closes the TCP
		// connection, due to network issues, load balancing, or server-side connection limits.
		catch (HttpRequestException ex) when (IsConnectionReset(ex))
		{
			if (attemptCount >= _options.MaxAttemptCount)
			{
				LogGivingUpOnTransientFailure(ex, logPrefix, attemptCount, request, "Connection reset by peer");
				throw;
			}

			// Wait 2 seconds and then retry (slightly longer delay for connection resets)
			await WaitAfterTransientFailureAsync(
				ex,
				logPrefix,
				attemptCount,
				request,
				"Connection reset by peer",
				TimeSpan.FromSeconds(2),
				cancellationToken)
				.ConfigureAwait(false);
			return null;
		}
	}

	private static bool IsConnectionReset(HttpRequestException ex)
		=> ex.Message.Contains("An error occurred while sending the request", StringComparison.OrdinalIgnoreCase)
			|| (ex.InnerException is not null && ex.InnerException.Message.Contains("Connection reset by peer", StringComparison.OrdinalIgnoreCase));

	private void LogGivingUpOnTransientFailure(
		Exception ex,
		string logPrefix,
		int attemptCount,
		HttpRequestMessage request,
		string reason)
		=> _logger.LogError(
			ex,
			"{LogPrefix}Giving up retrying. Received \"{Reason}\" on attempt {AttemptCount}/{MaxAttemptCount}. ({Method} - {Url})",
			logPrefix,
			reason,
			attemptCount,
			_options.MaxAttemptCount,
			request.Method.ToString(),
			request.RequestUri
			);

	private Task WaitAfterTransientFailureAsync(
		Exception ex,
		string logPrefix,
		int attemptCount,
		HttpRequestMessage request,
		string reason,
		TimeSpan delay,
		CancellationToken cancellationToken)
	{
		_logger.LogWarning(
			ex,
			"{LogPrefix}Received \"{Reason}\" on attempt {AttemptCount}/{MaxAttemptCount}. ({Method} - {Url})",
			logPrefix,
			reason,
			attemptCount,
			_options.MaxAttemptCount,
			request.Method.ToString(),
			request.RequestUri
			);

		return Task.Delay(delay, cancellationToken);
	}

	/// <summary>
	/// Decides whether the response warrants another attempt, and how long to wait first.
	/// </summary>
	/// <returns>True where the request should be retried after <paramref name="delay"/>.</returns>
	private bool TryGetRetryDelay(
		HttpResponseMessage httpResponseMessage,
		int statusCodeInt,
		int attemptCount,
		string logPrefix,
		HttpRequestMessage request,
		out TimeSpan delay)
	{
		switch (statusCodeInt)
		{
			case 429:
				// Jittered so that clients throttled in the same window, which Retry-After actively
				// aligns, do not all come back at the same instant. See ApplyJitter.
				delay = ApplyJitter(
					CalculateBackoffDelay(attemptCount, GetRetryAfterSeconds(httpResponseMessage), _options.BackOffDelayFactor, _options.MaxBackOffDelaySeconds),
					_options.MaxBackOffDelaySeconds,
					GetJitterRandom());

				LogAttemptStatus(LogLevel.Debug, logPrefix, statusCodeInt, attemptCount);
				return true;

			case 502:
			case 503:
			case 504:
				LogAttemptStatus(LogLevel.Information, logPrefix, statusCodeInt, attemptCount);
				delay = TimeSpan.FromSeconds(5);
				return true;

			default:
				if (attemptCount > 1)
				{
					LogAttemptStatus(LogLevel.Debug, logPrefix, statusCodeInt, attemptCount);
				}

				if (statusCodeInt == 500)
				{
					_logger.LogError(
						"{LogPrefix}Received remote error code 500 on attempt {AttemptCount}/{MaxAttemptCount}. ({Method} - {Url})",
						logPrefix,
						attemptCount,
						_options.MaxAttemptCount,
						request.Method.ToString(),
						request.RequestUri
						);
				}

				delay = TimeSpan.Zero;
				return false;
		}
	}

	/// <summary>
	/// Reads Retry-After, defaulting to one second where it is absent or unparseable.
	/// </summary>
	private static int GetRetryAfterSeconds(HttpResponseMessage httpResponseMessage)
	{
		var foundHeader = httpResponseMessage.Headers.TryGetValues("Retry-After", out var retryAfterHeaders);
		var retryAfterSecondsString = foundHeader
			? retryAfterHeaders?.FirstOrDefault() ?? "1"
			: "1";

		return int.TryParse(retryAfterSecondsString, out var retryAfterSeconds)
			? retryAfterSeconds
			: 1;
	}

#pragma warning disable CA1873 // Avoid potentially expensive logging
	private void LogAttemptStatus(LogLevel logLevel, string logPrefix, int statusCodeInt, int attemptCount)
		=> _logger.Log(
			logLevel,
			"{LogPrefix}Received {StatusCodeInt} on attempt {AttemptCount}/{MaxAttemptCount}.",
			logPrefix, statusCodeInt, attemptCount, _options.MaxAttemptCount
			);
#pragma warning restore CA1873 // Avoid potentially expensive logging

	/// <summary>
	/// Diagnostic logging is guarded, because building the message is more expensive than the check.
	/// </summary>
	private async Task LogRequestAsync(string logPrefix, HttpRequestMessage request, CancellationToken cancellationToken)
	{
		if (!_logger.IsEnabled(_levelToLogAt))
		{
			return;
		}

		_logger.Log(_levelToLogAt, "{LogPrefix}Request\r\n{Request}", logPrefix, request.ToRedactedString());
		if (request.Content != null)
		{
			var requestContent = await request.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
			_logger.Log(_levelToLogAt, "{LogPrefix}RequestContent\r\n{RequestContent}", logPrefix, requestContent);
		}
	}

	/// <inheritdoc cref="LogRequestAsync" />
	private async Task LogResponseAsync(string logPrefix, HttpResponseMessage httpResponseMessage, CancellationToken cancellationToken)
	{
		if (!_logger.IsEnabled(_levelToLogAt))
		{
			return;
		}

		_logger.Log(_levelToLogAt, "{LogPrefix}Response\r\n{HttpResponseMessage}", logPrefix, httpResponseMessage.ToRedactedString());
		if (httpResponseMessage.Content != null)
		{
			var responseContent = await httpResponseMessage.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
			_logger.Log(_levelToLogAt, "{LogPrefix}ResponseContent\r\n{ResponseContent}", logPrefix, responseContent);
		}
	}

	/// <summary>
	/// The maximum proportion by which <see cref="ApplyJitter"/> may extend a computed back-off delay.
	/// </summary>
	private const double JitterFraction = 0.5;

	private static Random GetJitterRandom() => Random.Shared;

	/// <summary>
	/// Spreads a computed back-off delay by a random amount, so that clients throttled at the same
	/// moment do not all retry at the same instant.
	/// <para>
	/// Meraki's rate limit is per organization and one API key is commonly used by several processes,
	/// or several replicas of one process, against the same organization. Retry-After makes this worse
	/// rather than better, because every throttled client is handed the same value and is therefore
	/// actively aligned by it.
	/// </para>
	/// <para>
	/// Jitter is only ever applied UPWARD. Where the server supplied a Retry-After, the delay passed in
	/// already honours it, so adding to that delay can never retry earlier than the server asked.
	/// </para>
	/// <para>
	/// Note the limitation at the ceiling: once <paramref name="delay"/> has reached
	/// <paramref name="maxBackOffDelaySeconds"/> there is no headroom left, and the delay is returned
	/// unchanged. Clients therefore re-align at the maximum. That is deliberate - keeping the documented
	/// maximum honoured matters more, and at a 30 second cycle the herd effect is far weaker than at one
	/// second, which is where the shipped defaults actually put it.
	/// </para>
	/// </summary>
	/// <param name="delay">The delay computed by <see cref="CalculateBackoffDelay"/>.</param>
	/// <param name="maxBackOffDelaySeconds">The configured ceiling, which jitter must not exceed.</param>
	/// <param name="random">The randomness source. Injected so that tests can seed it.</param>
	internal static TimeSpan ApplyJitter(
		TimeSpan delay,
		int maxBackOffDelaySeconds,
		Random random)
	{
		var delaySeconds = delay.TotalSeconds;
		var ceilingSeconds = Math.Min(delaySeconds * (1.0 + JitterFraction), maxBackOffDelaySeconds);

		// Where there is no headroom between the delay and the ceiling, leave the delay alone.
		return ceilingSeconds <= delaySeconds
			? delay
			// Retry jitter only has to de-synchronise concurrent clients; nothing here is a secret,
			// so System.Random is the right tool and a cryptographic generator would be waste.
			// nosemgrep: csharp_crypto_rule-WeakRNG
			: TimeSpan.FromSeconds(delaySeconds + (random.NextDouble() * (ceilingSeconds - delaySeconds)));
	}

	/// <summary>
	/// Applies the authentication scheme required by the selected Meraki API surface.
	/// </summary>
	/// <remarks>
	/// The Dashboard API accepts the traditional API-key header, while Cisco Workflows explicitly
	/// requires that same API key as a Bearer token. OAuth access tokens are Bearer tokens everywhere.
	/// </remarks>
	internal static void ApplyAuthentication(HttpRequestMessage request, MerakiClientOptions options)
	{
		var requestUri = request.RequestUri;
		var usesWorkflowsApi = requestUri is { IsAbsoluteUri: true }
			&& requestUri.AbsolutePath.StartsWith(
				"/api/automate/organizations/",
				StringComparison.OrdinalIgnoreCase);

		if (!string.IsNullOrWhiteSpace(options.AccessToken) || usesWorkflowsApi)
		{
			var credential = !string.IsNullOrWhiteSpace(options.AccessToken)
				? options.AccessToken
				: options.ApiKey;

			request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", credential);
			return;
		}

		request.Headers.Add("X-Cisco-Meraki-API-Key", options.ApiKey);
	}

	/// <summary>
	/// Calculate the back-off delay taking into account the retry-after header, the attemptcount and back-off factor and the maximum back-off delay.
	/// Wait at least retryAfterSeconds, then back off by the backOffDelayFactor to the power of the attemptCount, but no more than maxBackOffDelay.
	/// </summary>
	internal static TimeSpan CalculateBackoffDelay(
		int attemptCount,
		int retryAfterSeconds,
		double backOffDelayFactor,
		int maxBackOffDelaySeconds)
		=> TimeSpan.FromSeconds(
			Math.Min(
				Math.Max(
					// Wait as long as we can based on the attemptCount
					Math.Pow(backOffDelayFactor, attemptCount - 1),
					retryAfterSeconds
				),
				// But no longer than the maximum
				maxBackOffDelaySeconds)
			);
}
