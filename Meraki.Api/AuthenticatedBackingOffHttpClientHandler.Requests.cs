using Meraki.Api.Extensions;

namespace Meraki.Api;

// Codacy analyses each file on its own, so it reports 'partial' as gratuitous (S2333) and the static-only parts as S1118. The other parts live in sibling files.
#pragma warning disable S2333, S1118
internal sealed partial class AuthenticatedBackingOffHttpClientHandler
{
	/// <summary>
	/// Rejects requests that the configured options do not allow to be sent at all.
	/// </summary>
	private void EnsureRequestIsPermitted(HttpRequestMessage request)
	{
		// Simplistic IsReadOnly implementation to ensure only reading from the API
		if (_options.IsReadOnly && request.Method != HttpMethod.Get)
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
			// This was a timeout from our timeout token, not the original cancellation token,
			// so treat it as a timeout and retry.
			await WaitAfterTimeoutAsync(request, logPrefix, attemptCount, cancellationToken).ConfigureAwait(false);
			return null;
		}
		// A common error when contacting meraki nodes, so log it as a warning and retry.
		catch (HttpRequestException ex) when (ex.Message.StartsWith("Network is unreachable", StringComparison.Ordinal))
		{
			if (attemptCount >= _options.MaxAttemptCount)
			{
				LogGivingUpOnTransientFailure(ex, logPrefix, attemptCount, request, "Network is unreachable");
				throw;
			}

			// Wait 1 second and then retry
			await WaitAfterTransientFailureAsync(
				ex, logPrefix, attemptCount, request, "Network is unreachable", TimeSpan.FromSeconds(1), cancellationToken)
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
				ex, logPrefix, attemptCount, request, "Connection reset by peer", TimeSpan.FromSeconds(2), cancellationToken)
				.ConfigureAwait(false);
			return null;
		}
	}

	/// <summary>
	/// Logs an attempt timeout and waits out the back-off, or gives up once no attempts remain.
	/// </summary>
	/// <exception cref="TimeoutException">Thrown when every attempt timed out.</exception>
	private Task WaitAfterTimeoutAsync(
		HttpRequestMessage request,
		string logPrefix,
		int attemptCount,
		CancellationToken cancellationToken)
	{
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
			// The count is only worth stating when there was a retry. Keep the "The request timed out" opening:
			// consumers recognise this exhaustion by it.
			throw new TimeoutException(attemptCount > 1
				? $"The request timed out after {attemptCount} attempts."
				: "The request timed out.");
		}

		// Back off before retrying. A timeout usually means the far end is slow because it is
		// under load, so returning immediately is the least helpful response available, and it
		// is the one case where we have already waited HttpClientInnerTimeoutSeconds and so have
		// the least reason to expect the next attempt to be quicker. Every other retry path
		// pauses first.
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

		return Task.Delay(timeoutDelay, cancellationToken);
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
}
