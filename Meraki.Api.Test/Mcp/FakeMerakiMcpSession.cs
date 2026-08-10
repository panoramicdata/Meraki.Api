using Meraki.Api.Mcp;

namespace Meraki.Api.Test.Mcp;

/// <summary>
/// A controllable in-memory MCP session, so the client's guard rails, parsing, error taxonomy and
/// disposal semantics can be tested deterministically without a server or a child process.
/// </summary>
internal sealed class FakeMerakiMcpSession : IMerakiMcpSession
{
	public List<string> ToolNames { get; } = [MerakiMcpClient.SemanticSearchToolName, MerakiMcpClient.ExecuteApiToolName];

	public Func<string, IReadOnlyDictionary<string, object?>, CancellationToken, Task<MerakiMcpToolResponse>>? OnCallTool { get; set; }

	public Func<CancellationToken, Task<IReadOnlyList<string>>>? OnListToolNames { get; set; }

	public List<(string ToolName, IReadOnlyDictionary<string, object?> Arguments)> Calls { get; } = [];

	public int ListToolNamesCallCount { get; private set; }

	public int DisposeCount { get; private set; }

	public async Task<IReadOnlyList<string>> ListToolNamesAsync(CancellationToken cancellationToken)
	{
		ListToolNamesCallCount++;

		if (OnListToolNames is not null)
		{
			return await OnListToolNames(cancellationToken).ConfigureAwait(false);
		}

		cancellationToken.ThrowIfCancellationRequested();

		return ToolNames;
	}

	public async Task<MerakiMcpToolResponse> CallToolAsync(
		string toolName,
		IReadOnlyDictionary<string, object?> arguments,
		CancellationToken cancellationToken)
	{
		Calls.Add((toolName, arguments));

		if (OnCallTool is not null)
		{
			return await OnCallTool(toolName, arguments, cancellationToken).ConfigureAwait(false);
		}

		cancellationToken.ThrowIfCancellationRequested();

		return new MerakiMcpToolResponse(false, "{}", null);
	}

	public ValueTask DisposeAsync()
	{
		DisposeCount++;
		return ValueTask.CompletedTask;
	}
}
