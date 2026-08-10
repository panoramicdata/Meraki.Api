namespace Meraki.Api.Mcp;

/// <summary>
/// Thrown when a tool this client depends upon is not present in the MCP server's tool catalogue.
/// </summary>
/// <remarks>
/// The Meraki MCP server is in beta and Cisco documents that breaking changes are possible, so a
/// tool being renamed or withdrawn is a foreseeable failure. This exception names the missing tool
/// and the tools that were advertised, rather than failing later with a null reference.
/// </remarks>
public class MerakiMcpToolNotFoundException : MerakiMcpException
{
	/// <summary>
	/// The name of the tool that was expected but not advertised by the server.
	/// </summary>
	public string ToolName { get; } = string.Empty;

	/// <summary>
	/// The tool names the server did advertise.
	/// </summary>
	public IReadOnlyList<string> AvailableToolNames { get; } = [];

	/// <summary>
	/// Initializes a new instance of the <see cref="MerakiMcpToolNotFoundException"/> class.
	/// </summary>
	public MerakiMcpToolNotFoundException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="MerakiMcpToolNotFoundException"/> class with a specified error message.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	public MerakiMcpToolNotFoundException(string message)
		: base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="MerakiMcpToolNotFoundException"/> class with a specified error message and inner exception.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	/// <param name="innerException">The exception that is the cause of the current exception.</param>
	public MerakiMcpToolNotFoundException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="MerakiMcpToolNotFoundException"/> class for a
	/// named tool, listing the tools the server did advertise.
	/// </summary>
	/// <param name="toolName">The tool that was expected.</param>
	/// <param name="availableToolNames">The tools the server advertised.</param>
	public MerakiMcpToolNotFoundException(string toolName, IReadOnlyList<string> availableToolNames)
		: base(BuildMessage(toolName, availableToolNames))
	{
		ToolName = toolName;
		AvailableToolNames = availableToolNames;
	}

	private static string BuildMessage(string toolName, IReadOnlyList<string> availableToolNames)
	{
		var advertised = availableToolNames.Count == 0
			? "none"
			: string.Join(", ", availableToolNames);

		return $"The Meraki MCP server does not advertise a tool named '{toolName}'. Tools advertised: {advertised}. " +
			"The Meraki MCP server is in beta and its tool catalogue may change; check https://developer.cisco.com/meraki/api-v1/mcp-server/ and update this package if the tool has been renamed.";
	}
}
