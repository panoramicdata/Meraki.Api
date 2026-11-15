using Meraki.Api.Extensions;

namespace Meraki.Api;

// Codacy analyses each file on its own, so it reports 'partial' as gratuitous (S2333) and the static-only parts as S1118. The other parts live in sibling files.
#pragma warning disable S2333, S1118
internal sealed partial class AuthenticatedBackingOffHttpClientHandler
{
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
