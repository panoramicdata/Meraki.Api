namespace Meraki.Api.Mcp;

/// <summary>
/// Thrown when the MCP server cannot be reached, or when a stdio child process fails.
/// </summary>
public class MerakiMcpTransportException : MerakiMcpException
{
	/// <summary>
	/// The six static egress IP addresses Cisco publishes for the hosted MCP server.
	/// Outbound access to these may need allowlisting.
	/// </summary>
	public static IReadOnlyList<string> HostedEgressIpAddresses { get; } =
	[
		"158.115.141.245",
		"158.115.141.238",
		"158.115.141.209",
		"158.115.133.170",
		"158.115.133.139",
		"158.115.133.156"
	];

	/// <summary>
	/// Initializes a new instance of the <see cref="MerakiMcpTransportException"/> class.
	/// </summary>
	public MerakiMcpTransportException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="MerakiMcpTransportException"/> class with a specified error message.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	public MerakiMcpTransportException(string message)
		: base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="MerakiMcpTransportException"/> class with a specified error message and inner exception.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	/// <param name="innerException">The exception that is the cause of the current exception.</param>
	public MerakiMcpTransportException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	/// <summary>
	/// Builds the diagnostic hint appended to connectivity failures against the Cisco-hosted server.
	/// </summary>
	/// <returns>A hint naming the static egress addresses that may require allowlisting.</returns>
	public static string BuildHostedConnectivityHint()
		=> "Could not reach the Cisco-hosted Meraki MCP server. Cisco publishes six static egress IP addresses for this service, which may require allowlisting on your network: "
			+ string.Join(", ", HostedEgressIpAddresses)
			+ ". See https://developer.cisco.com/meraki/api-v1/mcp-server/.";
}
