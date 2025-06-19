namespace Meraki.Api.Data;

/// <summary>
/// Counts of devices by status
/// </summary>
[DataContract]
public class NetworkStatusSummaryStatusesByProductTypeItemCounts
{
	/// <summary>
	/// Count of alerting devices
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "alerting")]
	public int Alerting { get; set; }

	/// <summary>
	/// Count of dormant devices
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dormant")]
	public int Dormant { get; set; }

	/// <summary>
	/// Count of offline devices
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "offline")]
	public int Offline { get; set; }

	/// <summary>
	/// Count of online devices
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "online")]
	public int Online { get; set; }
}