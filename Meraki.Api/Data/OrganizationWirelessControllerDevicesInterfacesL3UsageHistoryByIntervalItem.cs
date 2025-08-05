namespace Meraki.Api.Data;

/// <summary>
/// Wireless LAN controller layer 3 interface usage
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesL3UsageHistoryByIntervalItem
{
	/// <summary>
	/// The cloud ID of the wireless LAN controller
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// The usages of layer 3 interfaces of the wireless LAN controller. Usage is in bytes
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "readings")]
	public List<OrganizationWirelessControllerDevicesInterfacesL3UsageHistoryByIntervalItemReading> Readings { get; set; } = [];
}
