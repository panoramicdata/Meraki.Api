namespace Meraki.Api;

/// <summary>
/// Meraki Client Statistic
/// </summary>
public class MerakiClientStatistic(int count, long totalDurationMs, long delayMs)
{
	/// <summary>
	/// Gets the count
	/// </summary>

	public int Count { get; set; } = count;
	/// <summary>
	/// Gets the total initial response duration ms
	/// </summary>

	public long TotalInitialResponseDurationMs { get; set; } = totalDurationMs;
	/// <summary>
	/// Gets the total client delay ms
	/// </summary>

	public long TotalClientDelayMs { get; set; } = delayMs;
}
