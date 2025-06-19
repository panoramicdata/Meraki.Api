namespace Meraki.Api.Data;

/// <summary>
/// The virtual routing and forwarding (VRF) for the wireless LAN controller interface
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesL3ByDeviceItemInterfaceVrf
{
	/// <summary>
	/// The virtual routing and forwarding (VRF) for the wireless LAN controller interface
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}
