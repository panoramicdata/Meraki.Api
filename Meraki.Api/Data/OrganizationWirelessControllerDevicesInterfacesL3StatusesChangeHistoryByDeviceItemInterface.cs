namespace Meraki.Api.Data;

/// <summary>
/// layer 3 interface that belongs to the wireless LAN controller
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesL3StatusesChangeHistoryByDeviceItemInterface
{
	/// <summary>
	/// The MAC address of the wireless LAN controller interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// The name of the wireless LAN controller interface
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The statuses of layer 3 interfaces of the wireless LAN controller
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "changes")]
	public List<OrganizationWirelessControllerDevicesInterfacesL3StatusesChangeHistoryByDeviceItemInterfaceChange> Changes { get; set; } = [];
}
