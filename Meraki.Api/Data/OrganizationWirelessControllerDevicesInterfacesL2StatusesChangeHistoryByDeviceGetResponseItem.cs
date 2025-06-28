namespace Meraki.Api.Data;

/// <summary>
/// Wireless LAN controller layer 2 interfaces historical status
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesL2StatusesChangeHistoryByDeviceGetResponseItem
{
	/// <summary>
	/// The cloud ID of the wireless LAN controller
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// layer 2 interfaces belongs to the wireless LAN controller
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "interfaces")]
	public List<OrganizationWirelessControllerDevicesInterfacesL2StatusesChangeHistoryByDeviceGetResponseItemInterface> Interfaces { get; set; } = [];
}
