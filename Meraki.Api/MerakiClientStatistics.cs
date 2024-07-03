namespace Meraki.Api;

public class MerakiClientStatistics
{
	public IReadOnlyDictionary<int, MerakiClientStatistic> StatusCodeCounts => _statusCodeCounts;

	private readonly Dictionary<int, MerakiClientStatistic> _statusCodeCounts = [];

	public int TotalRequestCount { get; private set; }

	internal void RecordStatusCode(int statusCode, long durationMs, long delayMs)
	{
		if (StatusCodeCounts.TryGetValue(statusCode, out var statistic))
		{
			statistic.Count++;
			statistic.TotalInitialResponseDurationMs += durationMs;
			statistic.TotalClientDelayMs += delayMs;
		}
		else
		{
			_statusCodeCounts.Add(statusCode, new(1, durationMs, delayMs));
		}

		TotalRequestCount++;
	}

	public void Reset()
	{
		_statusCodeCounts.Clear();
		TotalRequestCount = 0;
	}

	public override string ToString()
		=> $"Total Requests: {TotalRequestCount}, Status codes: {string.Join(", ", StatusCodeCounts.Select(x => $"{x.Key}: {x.Value.Count} ({x.Value.TotalInitialResponseDurationMs:N0}ms / {x.Value.TotalClientDelayMs:N0}ms)"))}";
}
