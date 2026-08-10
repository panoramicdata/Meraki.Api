namespace Meraki.Api.Mcp;

/// <summary>
/// The seam between <see cref="MerakiMcpClient"/> and an MCP session.
/// </summary>
/// <remarks>
/// Keeping the session behind an interface lets the client's guard rails, error taxonomy, parsing and
/// disposal semantics be unit tested deterministically, without a live server or a child process.
/// </remarks>
internal interface IMerakiMcpSession : IAsyncDisposable
{
	/// <summary>
	/// Lists the names of the tools the server advertises.
	/// </summary>
	Task<IReadOnlyList<string>> ListToolNamesAsync(CancellationToken cancellationToken);

	/// <summary>
	/// Calls a tool.
	/// </summary>
	Task<MerakiMcpToolResponse> CallToolAsync(
		string toolName,
		IReadOnlyDictionary<string, object?> arguments,
		CancellationToken cancellationToken);
}
