namespace Meraki.Api.Data;

/// <summary>
/// Wireless LAN controller CPU usage data item
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesSystemUtilizationHistoryByIntervalItem
{
	/// <summary>
	/// The cloud ID of the wireless LAN controller
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Time interval snapshots of CPU usage data of the wireless LAN controller
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "intervals")]
	public List<OrganizationWirelessControllerDevicesSystemUtilizationHistoryByIntervalItemInterval> Intervals { get; set; } = [];
}
