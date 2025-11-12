namespace Meraki.Api.Data;

/// <summary>
/// Organization Alert Condition
/// </summary>
[DataContract]
public class OrganizationAlertCondition
{
	/// <summary>
	/// The total duration in seconds that the threshold should be crossed before alerting
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "duration")]
	public int Duration { get; set; }

	/// <summary>
	/// The look back period in seconds for sensing the alert
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "window")]
	public int Window { get; set; }

	/// <summary>
	/// The threshold the metric must cross to be valid for alerting. Used only for WAN Utilization alerts.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "bit_rate_bps")]
	public int BitRateBps { get; set; }

	/// <summary>
	/// The uplink observed for the alert. interface must be one of the following: wan1, wan2, cellular
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "interface")]
	public string Interface { get; set; } = string.Empty;

	/// <summary>
	/// The threshold the metric must cross to be valid for alerting. Used only for VoIP Jitter alerts.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "jitter_ms")]
	public int JitterMs { get; set; }

	/// <summary>
	/// The threshold the metric must cross to be valid for alerting. Used only for WAN Latency alerts.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "latency_ms")]
	public int LatencyMs { get; set; }

	/// <summary>
	/// The threshold the metric must cross to be valid for alerting. Used only for Packet Loss alerts.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "loss_ratio")]
	public int LossRatio { get; set; }

	/// <summary>
	/// The threshold the metric must drop below to be valid for alerting. Used only for VoIP MOS alerts.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "mos")]
	public int Mos { get; set; }
}
