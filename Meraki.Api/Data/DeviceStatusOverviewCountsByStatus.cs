namespace Meraki.Api.Data;

[DataContract]
public class DeviceStatusOverviewCountsByStatus
{
	/// <summary>
	/// Online
	/// </summary>
	[DataMember(Name = "online")]
	public int Online { get; set; }

	/// <summary>
	/// Alerting
	/// </summary>
	[DataMember(Name = "alerting")]
	public int Alerting { get; set; }

	/// <summary>
	/// Offline
	/// </summary>
	[DataMember(Name = "offline")]
	public int Offline { get; set; }

	/// <summary>
	/// Dormant
	/// </summary>
	[DataMember(Name = "dormant")]
	public int Dormant { get; set; }
}
