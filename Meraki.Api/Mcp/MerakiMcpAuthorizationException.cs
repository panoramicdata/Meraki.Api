namespace Meraki.Api.Mcp;

/// <summary>
/// Thrown when the Meraki MCP server accepts the API key but refuses the request with HTTP 403.
/// </summary>
/// <remarks>
/// This indicates the key is valid but is not authorised for the organization or capability
/// requested. Contrast with <see cref="MerakiMcpAuthenticationException"/>, which indicates an
/// invalid key.
/// </remarks>
public class MerakiMcpAuthorizationException : MerakiMcpException
{
	/// <summary>
	/// Initializes a new instance of the <see cref="MerakiMcpAuthorizationException"/> class.
	/// </summary>
	public MerakiMcpAuthorizationException()
		: base("The Meraki MCP server accepted the API key but refused the request (HTTP 403). The key is valid but is not authorised for the organization or capability requested.")
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="MerakiMcpAuthorizationException"/> class with a specified error message.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	public MerakiMcpAuthorizationException(string message)
		: base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="MerakiMcpAuthorizationException"/> class with a specified error message and inner exception.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	/// <param name="innerException">The exception that is the cause of the current exception.</param>
	public MerakiMcpAuthorizationException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
