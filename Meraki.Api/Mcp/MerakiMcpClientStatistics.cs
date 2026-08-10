namespace Meraki.Api.Mcp;

/// <summary>
/// Statistics for a <see cref="MerakiMcpClient"/>.
/// </summary>
public class MerakiMcpClientStatistics
{
	/// <summary>
	/// HTTP status code statistics, recorded in the same way as <see cref="MerakiClientStatistics"/>.
	/// </summary>
	public MerakiClientStatistics Http { get; } = new();

#pragma warning disable IDE0044 // Don't add readonly modifier because it's modified via Interlocked
	private int _retryCount;
	private long _totalBackOffMs;
	private int _toolCallCount;
#pragma warning restore IDE0044

	/// <summary>
	/// The number of retries performed.
	/// </summary>
	public int RetryCount => _retryCount;

	/// <summary>
	/// The total time spent backing off, in milliseconds.
	/// </summary>
	public long TotalBackOffMs => _totalBackOffMs;

	/// <summary>
	/// The number of MCP tool calls made.
	/// </summary>
	public int ToolCallCount => _toolCallCount;

	internal void RecordRetry(TimeSpan delay)
	{
		_ = Interlocked.Increment(ref _retryCount);
		_ = Interlocked.Add(ref _totalBackOffMs, (long)delay.TotalMilliseconds);
	}

	internal void RecordToolCall() => Interlocked.Increment(ref _toolCallCount);

	/// <summary>
	/// Resets all statistics.
	/// </summary>
	public void Reset()
	{
		Http.Reset();
		_ = Interlocked.Exchange(ref _retryCount, 0);
		_ = Interlocked.Exchange(ref _totalBackOffMs, 0);
		_ = Interlocked.Exchange(ref _toolCallCount, 0);
	}

	/// <summary>
	/// Returns a string representation of the statistics.
	/// </summary>
	/// <returns>A formatted string showing tool call, retry and back-off statistics.</returns>
	public override string ToString()
		=> $"Tool calls: {ToolCallCount}, Retries: {RetryCount}, Back-off: {TotalBackOffMs:N0}ms. {Http}";
}
