namespace Meraki.Api.Data;

/// <summary>
/// Latency history
/// </summary>
[DataContract]
public class ClientLatencyHistory
{
	/// <summary>
	/// T0
	/// </summary>
	[DataMember(Name = "t0")]
	public int T0 { get; set; }

	/// <summary>
	/// T1
	/// </summary>
	[DataMember(Name = "t1")]
	public int T1 { get; set; }

	/// <summary>
	/// Latency bins by category
	/// </summary>
	[DataMember(Name = "latencyBinsByCategory")]
	public LatencyStats LatencyBinsByCategory { get; set; } = new();
}
