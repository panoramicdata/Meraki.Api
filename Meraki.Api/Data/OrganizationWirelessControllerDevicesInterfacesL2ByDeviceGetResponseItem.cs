namespace Meraki.Api.Data;

/// <summary>
/// Wireless LAN controller L2 interfaces
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesL2ByDeviceGetResponseItem
{
	/// <summary>
	/// The cloud ID of the wireless LAN controller
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Layer 2 interfaces belongs to the wireless LAN controller
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "interfaces")]
	public List<OrganizationWirelessControllerDevicesInterfacesL2ByDeviceGetResponseItemInterface> Interfaces { get; set; } = [];
}
