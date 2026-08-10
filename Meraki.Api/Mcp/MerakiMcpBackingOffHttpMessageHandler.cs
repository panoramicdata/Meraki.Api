namespace Meraki.Api.Mcp;

/// <summary>
/// Adds bearer authentication, retries and back-off to MCP HTTP traffic, and records statistics.
/// </summary>
/// <remarks>
/// This deliberately mirrors <see cref="AuthenticatedBackingOffHttpClientHandler"/>, which performs
/// the same job for the REST client. It is a <see cref="DelegatingHandler"/> rather than an
/// <see cref="HttpClientHandler"/> so that the retry and back-off logic can be unit tested against a
/// stub inner handler without a server.
/// </remarks>
internal sealed class MerakiMcpBackingOffHttpMessageHandler(
	MerakiMcpClientOptions options,
	MerakiMcpClientStatistics statistics,
	ILogger logger) : DelegatingHandler
{
	private const LogLevel LevelToLogAt = LogLevel.Trace;

	protected override async Task<HttpResponseMessage> SendAsync(
		HttpRequestMessage request,
		CancellationToken cancellationToken)
	{
		// Never log or otherwise emit the credential itself.
		request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", options.ApiKey);

		if (options.UserAgent is not null && !request.Headers.Contains("User-Agent"))
		{
			request.Headers.Add("User-Agent", options.UserAgent);
		}

		var attemptCount = 0;
		var stopwatch = new Stopwatch();

		while (true)
		{
			cancellationToken.ThrowIfCancellationRequested();
			attemptCount++;
			stopwatch.Restart();

			HttpResponseMessage response;
			try
			{
				response = await base
					.SendAsync(request, cancellationToken)
					.ConfigureAwait(false);
			}
			catch (HttpRequestException ex)
			{
				stopwatch.Stop();

				if (attemptCount >= options.MaxAttemptCount)
				{
					throw options.Transport == MerakiMcpTransport.HostedHttp
						? new MerakiMcpTransportException(MerakiMcpTransportException.BuildHostedConnectivityHint(), ex)
						: new MerakiMcpTransportException($"Could not reach the Meraki MCP server at {options.Uri}.", ex);
				}

				var transportDelay = TimeSpan.FromSeconds(1);
				logger.LogWarning(
					ex,
					"Meraki MCP transport failure on attempt {AttemptCount}/{MaxAttemptCount}. Retrying in {TotalSeconds:N1}s.",
					attemptCount,
					options.MaxAttemptCount,
					transportDelay.TotalSeconds);

				statistics.RecordRetry(transportDelay);
				await Task.Delay(transportDelay, cancellationToken).ConfigureAwait(false);
				continue;
			}

			stopwatch.Stop();

			var statusCodeInt = (int)response.StatusCode;
			var delay = TimeSpan.Zero;

			try
			{
				switch (statusCodeInt)
				{
					case 401:
						response.Dispose();
						throw new MerakiMcpAuthenticationException();

					case 403:
						response.Dispose();
						throw new MerakiMcpAuthorizationException();

					case 429:
						delay = AuthenticatedBackingOffHttpClientHandler.CalculateBackoffDelay(
							attemptCount,
							ReadRetryAfterSeconds(response),
							options.BackOffDelayFactor,
							options.MaxBackOffDelaySeconds);

#pragma warning disable CA1873 // Avoid potentially expensive logging
						logger.LogDebug(
							"Meraki MCP received 429 on attempt {AttemptCount}/{MaxAttemptCount}.",
							attemptCount,
							options.MaxAttemptCount);
#pragma warning restore CA1873 // Avoid potentially expensive logging

						if (attemptCount >= options.MaxAttemptCount)
						{
							response.Dispose();
							throw new MerakiMcpRateLimitException(attemptCount);
						}

						break;

					case 502:
					case 503:
					case 504:
						delay = TimeSpan.FromSeconds(5);

#pragma warning disable CA1873 // Avoid potentially expensive logging
						logger.LogInformation(
							"Meraki MCP received {StatusCodeInt} on attempt {AttemptCount}/{MaxAttemptCount}.",
							statusCodeInt,
							attemptCount,
							options.MaxAttemptCount);
#pragma warning restore CA1873 // Avoid potentially expensive logging

						if (attemptCount >= options.MaxAttemptCount)
						{
							return response;
						}

						break;

					default:
						if (logger.IsEnabled(LevelToLogAt))
						{
							logger.Log(
								LevelToLogAt,
								"Meraki MCP {Method} {Uri} returned {StatusCodeInt} on attempt {AttemptCount}.",
								request.Method.ToString(),
								request.RequestUri,
								statusCodeInt,
								attemptCount);
						}

						return response;
				}

				response.Dispose();
				statistics.RecordRetry(delay);
				await Task.Delay(delay, cancellationToken).ConfigureAwait(false);
			}
			finally
			{
				statistics.Http.RecordStatusCode(
					statusCodeInt,
					(long)stopwatch.Elapsed.TotalMilliseconds,
					(long)delay.TotalMilliseconds);
			}
		}
	}

	private static int ReadRetryAfterSeconds(HttpResponseMessage response)
	{
		if (!response.Headers.TryGetValues("Retry-After", out var values))
		{
			return 1;
		}

		var first = values.FirstOrDefault();

		return int.TryParse(first, out var seconds) && seconds >= 0
			? seconds
			: 1;
	}
}
