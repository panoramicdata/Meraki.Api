namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Controller Devices Interfaces L3 By Device Response
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesL3ByDeviceResponse
{
	/// <summary>
	/// 
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationWirelessControllerDevicesInterfaceL3ByDeviceMetadata Meta { get; set; } = new();

	/// <summary>
	/// Wireless LAN controller L3 interfaces
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationWirelessControllerDevicesInterfacesL3ByDeviceItem> Items { get; set; } = [];
}
