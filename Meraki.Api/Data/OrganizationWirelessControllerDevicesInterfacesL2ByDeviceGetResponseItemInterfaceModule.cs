namespace Meraki.Api.Data;

/// <summary>
/// The module of this wireless LAN controller interface
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesL2ByDeviceGetResponseItemInterfaceModule
{
	/// <summary>
	/// The module type of this wireless LAN controller interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "model")]
	public string Model { get; set; } = string.Empty;
}