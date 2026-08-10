namespace Meraki.Api.Mcp;

/// <summary>
/// Thrown when the MCP server continued to rate limit the client after the configured number of attempts.
/// </summary>
/// <remarks>
/// The Meraki MCP server respects the Dashboard API limit of 10 requests per second per organization.
/// Note that this budget is shared with any <see cref="MerakiClient"/> traffic in the same process.
/// </remarks>
public class MerakiMcpRateLimitException : MerakiMcpException
{
	/// <summary>
	/// The number of attempts made before giving up.
	/// </summary>
	public int AttemptCount { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="MerakiMcpRateLimitException"/> class.
	/// </summary>
	public MerakiMcpRateLimitException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="MerakiMcpRateLimitException"/> class with a specified error message.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	public MerakiMcpRateLimitException(string message)
		: base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="MerakiMcpRateLimitException"/> class with a specified error message and inner exception.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	/// <param name="innerException">The exception that is the cause of the current exception.</param>
	public MerakiMcpRateLimitException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="MerakiMcpRateLimitException"/> class for a given attempt count.
	/// </summary>
	/// <param name="attemptCount">The number of attempts made before giving up.</param>
	public MerakiMcpRateLimitException(int attemptCount)
		: base($"The Meraki MCP server continued to return HTTP 429 after {attemptCount} attempts. The Dashboard API limit is 10 requests per second per organization, and this budget is shared with any {nameof(MerakiClient)} traffic in the same process.")
	{
		AttemptCount = attemptCount;
	}
}
