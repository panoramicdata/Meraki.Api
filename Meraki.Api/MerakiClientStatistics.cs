namespace Meraki.Api;

public class MerakiClientStatistics
{
	public IReadOnlyDictionary<int, int> StatusCodeCounts => _statusCodeCounts;

	private readonly Dictionary<int, int> _statusCodeCounts = new();

	public int TotalRequestCount { get; internal set; }

	internal void RecordStatusCode(int statusCode)
	{
		if (StatusCodeCounts.TryGetValue(statusCode, out var count))
		{
			_statusCodeCounts[statusCode] = count + 1;
		}
		else
		{
			_statusCodeCounts.Add(statusCode, 1);
		}
	}
}