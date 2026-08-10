namespace Meraki.Api.Mcp;

/// <summary>
/// Thrown when the MCP server's response cannot be understood, or when the server reports an error
/// for a request this client made.
/// </summary>
/// <remarks>
/// Covers unknown capability identifiers, invalid parameter shapes, truncated or oversized payloads,
/// and protocol version mismatches.
/// </remarks>
public class MerakiMcpProtocolException : MerakiMcpException
{
	/// <summary>
	/// Initializes a new instance of the <see cref="MerakiMcpProtocolException"/> class.
	/// </summary>
	public MerakiMcpProtocolException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="MerakiMcpProtocolException"/> class with a specified error message.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	public MerakiMcpProtocolException(string message)
		: base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="MerakiMcpProtocolException"/> class with a specified error message and inner exception.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	/// <param name="innerException">The exception that is the cause of the current exception.</param>
	public MerakiMcpProtocolException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
