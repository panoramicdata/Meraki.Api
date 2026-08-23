namespace Meraki.Api.Mcp;

/// <summary>
/// Recognises Meraki Dashboard rate limiting in an MCP tool response, and retries around it
/// (issue #389).
/// </summary>
/// <remarks>
/// <para>
/// The server reports a rate limit <b>inside an otherwise successful tool response</b>, answering
/// the HTTP request with 200. So <see cref="MerakiMcpBackingOffHttpMessageHandler"/> - which can
/// only see status codes - never sees a 429, and its retry and back-off never engage. Without this
/// policy the first rate-limited call fails outright, however generous
/// <see cref="MerakiMcpClientOptions.MaxAttemptCount"/> is.
/// </para>
/// <para>
/// Rate limiting is an expected condition rather than an exceptional one: an agentic investigation
/// is several capability calls in quick succession, sharing the documented
/// 10-requests-per-second-per-organization budget with every other consumer of the same key.
/// Callers should not have to reimplement retry logic this library already performs for HTTP 429s,
/// and callers that hand these operations to a language model cannot retry reliably at all -
/// whether the model retries sensibly is not a decision to delegate.
/// </para>
/// <para>
/// This lives apart from <see cref="MerakiMcpClient"/> because it is a self-contained policy with
/// no dependency on client state, and because the client file was already large enough that adding
/// it there made the file the thing that was doing too much.
/// </para>
/// </remarks>
internal static class MerakiMcpRateLimitPolicy
{
	/// <summary>
	/// Message fragments that indicate Dashboard rate limiting.
	/// </summary>
	/// <remarks>
	/// Matched on text because the server supplies no machine-readable code for this, which is
	/// itself worth raising with Cisco. Deliberately tolerant of wording changes during the beta.
	/// </remarks>
	private static readonly string[] _rateLimitMessageFragments =
	[
		"rate limit",
		"ratelimit",
		"rate-limit",
		"too many requests",
		"429",
	];

	/// <summary>
	/// Invokes a tool call, retrying while the server reports that the rate limit was reached.
	/// </summary>
	/// <param name="callTool">Performs one tool call.</param>
	/// <param name="toolName">The tool being called, for logging.</param>
	/// <param name="options">The client options governing attempts and back-off.</param>
	/// <param name="statistics">Statistics to record each wait against.</param>
	/// <param name="logger">A logger.</param>
	/// <param name="cancellationToken">A cancellation token.</param>
	/// <returns>The first response that does not report a rate limit.</returns>
	/// <exception cref="MerakiMcpRateLimitException">
	/// Thrown when the server was still reporting a rate limit after
	/// <see cref="MerakiMcpClientOptions.MaxAttemptCount"/> attempts.
	/// </exception>
	internal static async Task<MerakiMcpToolResponse> CallWithRetryAsync(
		Func<CancellationToken, Task<MerakiMcpToolResponse>> callTool,
		string toolName,
		MerakiMcpClientOptions options,
		MerakiMcpClientStatistics statistics,
		ILogger logger,
		CancellationToken cancellationToken)
	{
		var attemptCount = 0;

		while (true)
		{
			cancellationToken.ThrowIfCancellationRequested();
			attemptCount++;

			var response = await callTool(cancellationToken).ConfigureAwait(false);

			if (!TryGetRateLimitMessage(response, out var rateLimitMessage))
			{
				return response;
			}

			if (attemptCount >= options.MaxAttemptCount)
			{
				throw new MerakiMcpRateLimitException(attemptCount);
			}

			var delay = AuthenticatedBackingOffHttpClientHandler.CalculateBackoffDelay(
				attemptCount,
				retryAfterSeconds: 1,
				options.BackOffDelayFactor,
				options.MaxBackOffDelaySeconds);

#pragma warning disable CA1873 // Avoid potentially expensive logging
			logger.LogDebug(
				"Meraki MCP tool {ToolName} reported a rate limit on attempt {AttemptCount}/{MaxAttemptCount} ({RateLimitMessage}). Waiting {TotalSeconds:N1}s.",
				toolName,
				attemptCount,
				options.MaxAttemptCount,
				rateLimitMessage,
				delay.TotalSeconds);
#pragma warning restore CA1873 // Avoid potentially expensive logging

			statistics.RecordRetry(delay);

			await Task.Delay(delay, cancellationToken).ConfigureAwait(false);
		}
	}

	/// <summary>
	/// Determines whether a tool response reports that the Meraki Dashboard rate limit was reached.
	/// </summary>
	/// <remarks>
	/// Checks both the MCP error flag and the payload error envelope, because the server has been
	/// observed using the latter for rate limiting.
	/// </remarks>
	internal static bool TryGetRateLimitMessage(MerakiMcpToolResponse response, out string message)
	{
		message = string.Empty;

		if (response.IsError)
		{
			if (!IsRateLimitMessage(response.Text))
			{
				return false;
			}

			message = response.Text!;
			return true;
		}

		var json = response.StructuredJson ?? response.Text;

		if (!MerakiMcpClient.TryReadPayloadError(json, out var payloadError)
			|| !IsRateLimitMessage(payloadError))
		{
			return false;
		}

		message = payloadError;
		return true;
	}

	/// <summary>
	/// Determines whether an error message describes Meraki Dashboard rate limiting.
	/// </summary>
	internal static bool IsRateLimitMessage(string? message)
	{
		if (string.IsNullOrWhiteSpace(message))
		{
			return false;
		}

		foreach (var fragment in _rateLimitMessageFragments)
		{
			if (message!.Contains(fragment, StringComparison.OrdinalIgnoreCase))
			{
				return true;
			}
		}

		return false;
	}
}
