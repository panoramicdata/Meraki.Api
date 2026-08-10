namespace Meraki.Api.Mcp;

/// <summary>
/// The outcome of a non-destructive connectivity and credential check against the MCP server.
/// </summary>
public class MerakiMcpStatus
{
	/// <summary>
	/// True when the server was reachable, the credential was accepted, and both required tools were advertised.
	/// </summary>
	public bool IsConnected { get; private set; }

	/// <summary>
	/// A description of why the check failed, when it failed.
	/// </summary>
	public string? Message { get; private set; }

	/// <summary>
	/// The tool names the server advertised.
	/// </summary>
	public IReadOnlyList<string> AvailableToolNames { get; private set; } = [];

	/// <summary>
	/// Creates a connected status.
	/// </summary>
	/// <param name="availableToolNames">The tool names the server advertised.</param>
	/// <returns>A connected status.</returns>
	public static MerakiMcpStatus Connected(IReadOnlyList<string> availableToolNames)
		=> new()
		{
			IsConnected = true,
			AvailableToolNames = availableToolNames
		};

	/// <summary>
	/// Creates a disconnected status.
	/// </summary>
	/// <param name="message">A description of why the check failed. Must never contain a credential.</param>
	/// <returns>A disconnected status.</returns>
	public static MerakiMcpStatus Disconnected(string message)
		=> new()
		{
			IsConnected = false,
			Message = message
		};

	/// <summary>
	/// Returns a string representation of the status.
	/// </summary>
	/// <returns>The connection state and, when disconnected, the reason.</returns>
	public override string ToString()
		=> IsConnected
			? $"Connected. Tools: {string.Join(", ", AvailableToolNames)}"
			: $"Disconnected. {Message}";
}
