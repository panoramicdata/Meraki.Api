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

	// Guarded, because the concurrency tests drive this from many threads at once. An unsynchronised
	// List would silently lose entries and make those tests flaky.
	private readonly List<(string ToolName, IReadOnlyDictionary<string, object?> Arguments)> _calls = [];
	private readonly object _callsLock = new();

	public IReadOnlyList<(string ToolName, IReadOnlyDictionary<string, object?> Arguments)> Calls
	{
		get
		{
			lock (_callsLock)
			{
				return [.. _calls];
			}
		}
	}

	private int _listToolNamesCallCount;

	public int ListToolNamesCallCount => _listToolNamesCallCount;

	public int DisposeCount { get; private set; }

	public async Task<IReadOnlyList<string>> ListToolNamesAsync(CancellationToken cancellationToken)
	{
		_ = Interlocked.Increment(ref _listToolNamesCallCount);

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
		lock (_callsLock)
		{
			_calls.Add((toolName, arguments));
		}

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
