namespace Meraki.Api.Data;

/// <summary>
/// Wireless LAN controller interfaces usage data
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesUsageHistoryByIntervalItem
{
	/// <summary>
	/// The cloud ID of the wireless LAN controller
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Time interval snapshots of interfaces usage data of the wireless LAN controller
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "intervals")]
	public List<OrganizationWirelessControllerDevicesInterfacesUsageHistoryByIntervalItemInterval> Intervals { get; set; } = [];
}
