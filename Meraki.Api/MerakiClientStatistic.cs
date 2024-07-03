namespace Meraki.Api;

public class MerakiClientStatistic(int count, long totalDurationMs, long delayMs)
{
	public int Count { get; set; } = count;
	public long TotalInitialResponseDurationMs { get; set; } = totalDurationMs;
	public long TotalClientDelayMs { get; set; } = delayMs;
}