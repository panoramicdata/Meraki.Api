﻿namespace Meraki.Api;

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

			try
			{
				httpResponseMessage = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
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

						delay = TimeSpan.FromSeconds(1.1 * retryAfterSeconds);
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
}
