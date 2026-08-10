namespace Meraki.Api.Mcp;

/// <summary>
/// The base class for all Meraki MCP client exceptions.
/// </summary>
public class MerakiMcpException : Exception
{
	/// <summary>
	/// Initializes a new instance of the <see cref="MerakiMcpException"/> class.
	/// </summary>
	public MerakiMcpException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="MerakiMcpException"/> class with a specified error message.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	public MerakiMcpException(string message)
		: base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="MerakiMcpException"/> class with a specified error message and inner exception.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	/// <param name="innerException">The exception that is the cause of the current exception.</param>
	public MerakiMcpException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
