namespace Meraki.Api.Data;

/// <summary>
/// Health by time
/// </summary>
[DataContract]
public class HealthByTime
{
	/// <summary>
	/// StartTs
	/// </summary>
	[DataMember(Name = "startTs")]
	public string StartTs { get; set; } = string.Empty;

	/// <summary>
	/// EndTs
	/// </summary>
	[DataMember(Name = "endTs")]
	public string EndTs { get; set; } = string.Empty;

	/// <summary>
	/// Wan Goodput
	/// </summary>
	[DataMember(Name = "wanGoodput")]
	public int WanGoodput { get; set; }

	/// <summary>
	/// Lan Goodput
	/// </summary>
	[DataMember(Name = "lanGoodput")]
	public int LanGoodput { get; set; }

	/// <summary>
	/// Wan latency ms
	/// </summary>
	[DataMember(Name = "wanLatencyMs")]
	public double WanLatencyMs { get; set; }

	/// <summary>
	/// Lan latency ms
	/// </summary>
	[DataMember(Name = "lanLatencyMs")]
	public double LanLatencyMs { get; set; }

	/// <summary>
	/// Wan loss percent
	/// </summary>
	[DataMember(Name = "wanLossPercent")]
	public double WanLossPercent { get; set; }

	/// <summary>
	/// Lan loss percent
	/// </summary>
	[DataMember(Name = "lanLossPercent")]
	public double LanLossPercent { get; set; }

	/// <summary>
	/// Response duration
	/// </summary>
	[DataMember(Name = "responseDuration")]
	public int ResponseDuration { get; set; }

	/// <summary>
	/// Sent
	/// </summary>
	[DataMember(Name = "sent")]
	public int Sent { get; set; }

	/// <summary>
	/// Recv
	/// </summary>
	[DataMember(Name = "recv")]
	public int Recv { get; set; }

	/// <summary>
	/// Num clients
	/// </summary>
	[DataMember(Name = "numClients")]
	public int NumClients { get; set; }
}
