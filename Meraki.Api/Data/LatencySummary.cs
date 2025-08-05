namespace Meraki.Api.Data;

/// <summary>
/// Latency summary
/// </summary>
public class LatencySummary
{
	/// <summary>
	/// Sender uplink
	/// </summary>
	[DataMember(Name = "senderUplink")]
	public string SenderUplink { get; set; } = string.Empty;

	/// <summary>
	/// Receiver uplink
	/// </summary>
	[DataMember(Name = "receiverUplink")]
	public string ReceiverUplink { get; set; } = string.Empty;

	/// <summary>
	/// Average latency ms
	/// </summary>
	[DataMember(Name = "avgLatencyMs")]
	public double AvgLatencyMs { get; set; }

	/// <summary>
	/// Minimum latency ms
	/// </summary>
	[DataMember(Name = "minLatencyMs")]
	public double MinLatencyMs { get; set; }

	/// <summary>
	/// Maximum latency ms
	/// </summary>
	[DataMember(Name = "maxLatencyMs")]
	public double MaxLatencyMs { get; set; }
}
