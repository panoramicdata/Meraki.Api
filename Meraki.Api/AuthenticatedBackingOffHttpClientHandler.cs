namespace Meraki.Api;

internal sealed class AuthenticatedBackingOffHttpClientHandler(
	MerakiClientOptions options,
	MerakiClient merakiClient,
	ILogger logger) : HttpClientHandler
{
	private readonly MerakiClientOptions _options = options;
	private readonly MerakiClient _merakiClient = merakiClient;
	private readonly ILogger _logger = logger;
	private readonly LogLevel _levelToLogAt = LogLevel.Trace;

	public string LastRequestUri { get; private set; } = string.Empty;

	public MerakiClientStatistics Statistics { get; } = new();

	private readonly Stopwatch _durationStopWatch = new();

	protected override async Task<HttpResponseMessage> SendAsync(
		HttpRequestMessage request,
		CancellationToken cancellationToken)
	{
		if (_options.ReadOnly)
		{
			// Simplistic ReadOnly implementation to ensure only reading from the API
			// Check that this is a GET
			if (request.Method != HttpMethod.Get)
			{
				throw new InvalidOperationException(Resources.OnlyReadOnlyOperationsPermitted);
			}
		}

		// Ensure the API key is set
		if (_options.ApiKey?.Length == 0)
		{
			throw new InvalidOperationException(Resources.ApiKeyIsNotSet);
		}
		// The API Key is set

		// Apply rate limiting if we have a rate limiter
		if (_options.RateLimiter is not null)
		{
			await _options
				.RateLimiter
				.ApplyRateLimitingAsync(
					request,
					cancellationToken)
				.ConfigureAwait(false);
		}

		var logPrefix = $"Request {Guid.NewGuid()}: ";

		// Add the request headers
		request.Headers.Add("X-Cisco-Meraki-API-Key", _options.ApiKey);
		if (_options.UserAgent is not null)
		{
			request.Headers.Add("User-Agent", _options.UserAgent);
		}

		var attemptCount = 0;
		while (true)
		{
			_durationStopWatch.Restart();
			attemptCount++;
			cancellationToken.ThrowIfCancellationRequested();

			// Only do diagnostic logging if we're at the level we want to enable for as this is more efficient
			if (_logger.IsEnabled(_levelToLogAt))
			{
				_logger.Log(_levelToLogAt, "{LogPrefix}Request\r\n{Request}", logPrefix, request);
				if (request.Content != null)
				{
					var requestContent = await request.Content.ReadAsStringAsync().ConfigureAwait(false);
					_logger.Log(_levelToLogAt, "{LogPrefix}RequestContent\r\n{RequestContent}", logPrefix, requestContent);
				}
			}

			LastRequestUri = request.RequestUri.ToString();

			// Complete the action
			HttpResponseMessage httpResponseMessage;

			// Create a new CancellationToken derived from the original, but with a timeout
			using var timeoutCancellationSource = new CancellationTokenSource(TimeSpan.FromSeconds(_options.HttpClientInnerTimeoutSeconds));
			var timeoutToken = timeoutCancellationSource.Token;

			try
			{
				httpResponseMessage = await base
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

				_logger.LogWarning(
					"{LogPrefix}Timed out after {TimeoutSeconds:N1} seconds on attempt {AttemptCount}/{MaxAttemptCount}. ({Method} - {Url})",
					logPrefix,
					_options.HttpClientInnerTimeoutSeconds,
					attemptCount,
					_options.MaxAttemptCount,
					request.Method.ToString(),
					request.RequestUri
					);

				// Retry immediately
				continue;
			}
			catch (HttpRequestException ex) when (ex.Message.StartsWith("Network is unreachable", StringComparison.Ordinal))
			{
				// This is a common error that seems to occur when contacting meraki nodes, so we'll log it as a warning and retry

				// Try up to the maximum retry count.
				if (attemptCount >= _options.MaxAttemptCount)
				{
					_logger.LogError(
						"{LogPrefix}Giving up retrying. Received \"Network is unreachable\" on attempt {AttemptCount}/{MaxAttemptCount}. ({Method} - {Url})",
						logPrefix, attemptCount, _options.MaxAttemptCount,
						request.Method.ToString(),
						request.RequestUri
						);
					throw;
				}

				_logger.LogWarning(
					"{LogPrefix}Received \"Network is unreachable\" on attempt {AttemptCount}/{MaxAttemptCount}. ({Method} - {Url})",
					logPrefix, attemptCount, _options.MaxAttemptCount,
					request.Method.ToString(),
					request.RequestUri
					);

				// Wait 1 seconds and then retry
				await Task.Delay(TimeSpan.FromSeconds(1), cancellationToken).ConfigureAwait(false);
				continue;
			}
			catch (HttpRequestException ex) when (
				ex.Message.IndexOf("An error occurred while sending the request", StringComparison.OrdinalIgnoreCase) >= 0 ||
				ex.InnerException?.Message.IndexOf("Connection reset by peer", StringComparison.OrdinalIgnoreCase) >= 0)
			{
				// This is a common error that occurs when the remote server (Meraki API) abruptly closes the TCP connection
				// This can happen due to network issues, load balancing, or server-side connection limits

				// Try up to the maximum retry count.
				if (attemptCount >= _options.MaxAttemptCount)
				{
					_logger.LogError(
						ex,
						"{LogPrefix}Giving up retrying. Received \"Connection reset by peer\" on attempt {AttemptCount}/{MaxAttemptCount}. ({Method} - {Url})",
						logPrefix, attemptCount, _options.MaxAttemptCount,
						request.Method.ToString(),
						request.RequestUri
						);
					throw;
				}

				_logger.LogWarning(
					"{LogPrefix}Received \"Connection reset by peer\" on attempt {AttemptCount}/{MaxAttemptCount}. ({Method} - {Url})",
					logPrefix, attemptCount, _options.MaxAttemptCount,
					request.Method.ToString(),
					request.RequestUri
					);

				// Wait 2 seconds and then retry (slightly longer delay for connection resets)
				await Task.Delay(TimeSpan.FromSeconds(2), cancellationToken).ConfigureAwait(false);
				continue;
			}

			_merakiClient.LastResponseHeaders = httpResponseMessage.Headers;

			// Only do diagnostic logging if we're at the level we want to enable for as this is more efficient
			if (_logger.IsEnabled(_levelToLogAt))
			{
				_logger.Log(_levelToLogAt, "{LogPrefix}Response\r\n{HttpResponseMessage}", logPrefix, httpResponseMessage);
				if (httpResponseMessage.Content != null)
				{
					var responseContent = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
					_logger.Log(_levelToLogAt, "{LogPrefix}ResponseContent\r\n{ResponseContent}", logPrefix, responseContent);
				}
			}

			// Only record the time we spent processing the request/response
			_durationStopWatch.Stop();

			TimeSpan delay;
			// As long as we were not given a back-off request then we'll return the response and any further StatusCode handling is up to the caller
			var statusCodeInt = (int)httpResponseMessage.StatusCode;

			try
			{
				switch (statusCodeInt)
				{
					case 429:
						// Back off by the requested amount.
						var headers = httpResponseMessage.Headers;
						var foundHeader = headers.TryGetValues("Retry-After", out var retryAfterHeaders);
						var retryAfterSecondsString = foundHeader
							? retryAfterHeaders.FirstOrDefault() ?? "1"
							: "1";
						if (!int.TryParse(retryAfterSecondsString, out var retryAfterSeconds))
						{
							retryAfterSeconds = 1;
						}

						delay = CalculateBackoffDelay(attemptCount, retryAfterSeconds, _options.BackOffDelayFactor, _options.MaxBackOffDelaySeconds);

						_logger.LogDebug(
							"{LogPrefix}Received {StatusCodeInt} on attempt {AttemptCount}/{MaxAttemptCount}.",
							logPrefix, statusCodeInt, attemptCount, _options.MaxAttemptCount
							);
						break;
					case 502:
					case 503:
					case 504:
						_logger.LogInformation(
							"{LogPrefix}Received {StatusCodeInt} on attempt {AttemptCount}/{MaxAttemptCount}.",
							logPrefix, statusCodeInt, attemptCount, _options.MaxAttemptCount
							);
						delay = TimeSpan.FromSeconds(5);
						break;
					default:
						if (attemptCount > 1)
						{
							_logger.LogDebug(
								"{LogPrefix}Received {StatusCodeInt} on attempt {AttemptCount}/{MaxAttemptCount}.",
								logPrefix, statusCodeInt, attemptCount, _options.MaxAttemptCount
								);
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

						return httpResponseMessage;
				}

				// Try up to the maximum retry count.
				if (attemptCount >= _options.MaxAttemptCount)
				{
					_logger.LogInformation(
						"{LogPrefix}Giving up retrying. Returning {StatusCodeInt} on attempt {AttemptCount}/{MaxAttemptCount}. ({Method} - {Url})",
						logPrefix,
						statusCodeInt,
						attemptCount,
						_options.MaxAttemptCount,
						request.Method.ToString(),
						request.RequestUri
						);
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
					request.RequestUri
					);

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
