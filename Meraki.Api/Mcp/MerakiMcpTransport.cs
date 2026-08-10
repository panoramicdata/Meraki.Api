namespace Meraki.Api.Mcp;

/// <summary>
/// The transport used to reach a Meraki MCP server.
/// </summary>
/// <remarks>
/// See <see href="https://developer.cisco.com/meraki/api-v1/mcp-server/">Meraki MCP Server</see>.
/// </remarks>
public enum MerakiMcpTransport
{
	/// <summary>
	/// The Cisco-hosted remote MCP server at https://mcp.meraki.com/mcp, over Streamable HTTP.
	/// This supports Meraki.com environments only; it does not support Federal, GovCloud or localised instances.
	/// </summary>
	HostedHttp = 0,

	/// <summary>
	/// A self-hosted instance of the open-source MCP server, reached over Streamable HTTP at
	/// <see cref="MerakiMcpClientOptions.Uri"/>. Use this for any Meraki environment that the
	/// Cisco-hosted server does not support.
	/// </summary>
	LocalHttp = 1,

	/// <summary>
	/// A self-hosted instance of the open-source MCP server, launched as a child process and
	/// communicated with over stdin and stdout.
	/// </summary>
	Stdio = 2
}
