namespace Meraki.Api.Data;

/// <summary>
/// 
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesL3ByDeviceItemInterfaceModule
{
	/// <summary>
	/// The module type of this wireless LAN controller interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "model")]
	public string Model { get; set; } = string.Empty;
}
