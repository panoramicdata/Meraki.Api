namespace Meraki.Api.Data;

/// <summary>
/// Loss and latency history
/// </summary>
[DataContract]
public class LossAndLatencyHistory
{
	/// <summary>
	/// Start time
	/// </summary>
	[DataMember(Name = "startTime")]
	public DateTime StartTime { get; set; }

	/// <summary>
	/// End time
	/// </summary>
	[DataMember(Name = "endTime")]
	public DateTime EndTime { get; set; }

	/// <summary>
	/// Loss percentage
	/// </summary>
	[DataMember(Name = "lossPercent")]
	public double LossPercentage { get; set; }

	/// <summary>
	/// Latency ms
	/// </summary>
	[DataMember(Name = "latencyMs")]
	public double LatencyMs { get; set; }

	/// <summary>
	/// Goodput in kilobits per second for a wired network device
	/// </summary>
	[DataMember(Name = "goodput")]
	public int Goodput { get; set; }

	/// <summary>
	/// Jitter
	/// </summary>
	[DataMember(Name = "jitter")]
	public double Jitter { get; set; }
}
