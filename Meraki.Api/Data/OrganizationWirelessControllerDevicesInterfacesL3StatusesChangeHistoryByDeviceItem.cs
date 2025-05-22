namespace Meraki.Api.Data;

/// <summary>
/// Wireless LAN controller layer 3 interface historical status
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesL3StatusesChangeHistoryByDeviceItem
{
	/// <summary>
	/// The cloud ID of the wireless LAN controller
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// layer 3 interfaces belongs to the wireless LAN controller
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "interfaces")]
	public List<OrganizationWirelessControllerDevicesInterfacesL3StatusesChangeHistoryByDeviceItemInterface> Interfaces { get; set; } = [];
}
