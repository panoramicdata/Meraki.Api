namespace Meraki.Api.Mcp;

/// <summary>
/// Thrown when the Meraki MCP server rejects the API key with HTTP 401.
/// </summary>
/// <remarks>
/// This indicates the key itself is invalid, expired, or malformed. Contrast with
/// <see cref="MerakiMcpAuthorizationException"/>, which indicates a valid key without access.
/// </remarks>
public class MerakiMcpAuthenticationException : MerakiMcpException
{
	/// <summary>
	/// Initializes a new instance of the <see cref="MerakiMcpAuthenticationException"/> class.
	/// </summary>
	public MerakiMcpAuthenticationException()
		: base("The Meraki MCP server rejected the API key (HTTP 401). The key is invalid, expired or malformed.")
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="MerakiMcpAuthenticationException"/> class with a specified error message.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	public MerakiMcpAuthenticationException(string message)
		: base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="MerakiMcpAuthenticationException"/> class with a specified error message and inner exception.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	/// <param name="innerException">The exception that is the cause of the current exception.</param>
	public MerakiMcpAuthenticationException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
