using Meraki.Api.Extensions;

namespace Meraki.Api;

internal sealed partial class AuthenticatedBackingOffHttpClientHandler : DelegatingHandler
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
		// Spans every attempt and every wait, unlike _durationStopWatch which times one attempt.
		var totalStopwatch = Stopwatch.StartNew();

		while (true)
		{
			_durationStopWatch.Restart();
			attemptCount++;
			cancellationToken.ThrowIfCancellationRequested();

			await LogRequestAsync(logPrefix, request, cancellationToken).ConfigureAwait(false);

			LastRequestUri = request.RequestUri?.ToString() ?? string.Empty;

			using var timeoutCancellationSource = CreateAttemptTimeout(cancellationToken);

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

			await RecordResponseAsync(logPrefix, httpResponseMessage, cancellationToken).ConfigureAwait(false);

			// Non-null is the caller's answer; null means another attempt is due.
			var handled = await HandleResponseAsync(
				httpResponseMessage,
				logPrefix,
				attemptCount,
				request,
				totalStopwatch,
				cancellationToken)
				.ConfigureAwait(false);
			if (handled is not null)
			{
				return handled;
			}
		}
	}

	/// <summary>
	/// Decides what a completed attempt means, waiting out any back-off it calls for, and records the
	/// status code either way.
	/// </summary>
	/// <returns>
	/// The response to hand to the caller, or null once the back-off is over and another attempt is due.
	/// </returns>
	private async Task<HttpResponseMessage?> HandleResponseAsync(
		HttpResponseMessage httpResponseMessage,
		string logPrefix,
		int attemptCount,
		HttpRequestMessage request,
		Stopwatch totalStopwatch,
		CancellationToken cancellationToken)
	{
		var delay = TimeSpan.Zero;
		var statusCodeInt = (int)httpResponseMessage.StatusCode;

		try
		{
			// As long as we were not given a back-off request then we'll return the response and any
			// further StatusCode handling is up to the caller.
			return !TryGetRetryDelay(httpResponseMessage, statusCodeInt, attemptCount, logPrefix, request, out delay)
				? httpResponseMessage
				: await WaitOrGiveUpAsync(
					httpResponseMessage,
					statusCodeInt,
					attemptCount,
					delay,
					logPrefix,
					request,
					totalStopwatch,
					cancellationToken)
					.ConfigureAwait(false);
		}
		finally
		{
			// Record the status code
			Statistics.RecordStatusCode(statusCodeInt, (long)_durationStopWatch.Elapsed.TotalMilliseconds, (long)delay.TotalMilliseconds);
		}
	}

	/// <summary>
	/// The token for one attempt: the caller's token plus the inner timeout, so either can abort it.
	/// </summary>
	/// <remarks>
	/// The catch filter in <see cref="TrySendAsync"/> tells the two apart, treating the failure as a
	/// timeout only when the caller has not cancelled.
	/// </remarks>
	private CancellationTokenSource CreateAttemptTimeout(CancellationToken cancellationToken)
	{
		var source = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
		source.CancelAfter(TimeSpan.FromSeconds(_options.HttpClientInnerTimeoutSeconds));

		return source;
	}

	/// <summary>
	/// Publishes the response headers, logs the response, and stops the per-attempt timer, which
	/// times the request and response only and not any back-off that follows.
	/// </summary>
	private async Task RecordResponseAsync(
		string logPrefix,
		HttpResponseMessage httpResponseMessage,
		CancellationToken cancellationToken)
	{
		_merakiClient.LastResponseHeaders = httpResponseMessage.Headers;

		await LogResponseAsync(logPrefix, httpResponseMessage, cancellationToken).ConfigureAwait(false);

		_durationStopWatch.Stop();
	}

	/// <summary>
	/// Waits out the back-off before the next attempt, or ends the retry loop when the budget is
	/// spent.
	/// </summary>
	/// <returns>
	/// The response the caller should receive when no attempts remain, or null once the wait is over
	/// and another attempt is due. Throws <see cref="RetryExhaustedException"/> instead of returning
	/// where the caller opted into that.
	/// </returns>
#pragma warning disable CA1873 // Avoid potentially expensive logging
	private async Task<HttpResponseMessage?> WaitOrGiveUpAsync(
		HttpResponseMessage httpResponseMessage,
		int statusCodeInt,
		int attemptCount,
		TimeSpan delay,
		string logPrefix,
		HttpRequestMessage request,
		Stopwatch totalStopwatch,
		CancellationToken cancellationToken)
	{
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
				request.RequestUri);

			if (!_options.ThrowOnRetryExhaustion)
			{
				return httpResponseMessage;
			}

			// The caller asked to be told about exhaustion explicitly rather than receive a
			// response indistinguishable from a first-attempt failure.
			httpResponseMessage.Dispose();
			throw new RetryExhaustedException(
				httpResponseMessage.StatusCode,
				attemptCount,
				_options.MaxAttemptCount,
				totalStopwatch.Elapsed,
				request.Method,
				request.RequestUri);
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

		await Task.Delay(delay, cancellationToken).ConfigureAwait(false);

		return null;
	}
#pragma warning restore CA1873 // Avoid potentially expensive logging
}
