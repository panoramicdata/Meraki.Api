using System.Collections.Concurrent;

namespace Meraki.Api;

/// <summary>
/// Meraki Client Statistics
/// </summary>
public class MerakiClientStatistics
{
	public IReadOnlyDictionary<int, MerakiClientStatistic> StatusCodeCounts => _statusCodeCounts;

	private readonly ConcurrentDictionary<int, MerakiClientStatistic> _statusCodeCounts = new();

	private int _totalRequestCount;
	public int TotalRequestCount => _totalRequestCount;

	internal void RecordStatusCode(int statusCode, long durationMs, long delayMs)
	{
		_ = _statusCodeCounts.AddOrUpdate(
			statusCode,
			_ => new MerakiClientStatistic(1, durationMs, delayMs),
			(_, stat) =>
			{
				stat.Count++;
				stat.TotalInitialResponseDurationMs += durationMs;
				stat.TotalClientDelayMs += delayMs;
				return stat;
			});

		_ = Interlocked.Increment(ref _totalRequestCount);
	}

	/// <summary>
	/// Reset
	/// </summary>
	public void Reset()
	{
		_statusCodeCounts.Clear();
		_ = Interlocked.Exchange(ref _totalRequestCount, 0);
	}

	public override string ToString()
		=> $"Total Requests: {TotalRequestCount}, Status codes: {string.Join(", ", StatusCodeCounts.Select(x => $"{x.Key}: {x.Value.Count} ({x.Value.TotalInitialResponseDurationMs:N0}ms / {x.Value.TotalClientDelayMs:N0}ms)"))}";
}
