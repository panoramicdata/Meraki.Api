namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Controller Devices System Utilization History By Interval
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesSystemUtilizationHistoryByInterval
{
	/// <summary>
	/// Metadata relevant to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationWirelessControllerDevicesSystemUtilizationHistoryByIntervalMetadata Meta { get; set; } = new();

	/// <summary>
	/// Wireless LAN controller CPU usage data
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationWirelessControllerDevicesSystemUtilizationHistoryByIntervalItem> Items { get; set; } = [];
}
