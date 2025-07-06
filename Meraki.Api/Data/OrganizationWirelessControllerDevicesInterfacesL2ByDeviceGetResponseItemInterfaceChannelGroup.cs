namespace Meraki.Api.Data;

/// <summary>
/// The channel group of this wireless LAN controller interface
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesL2ByDeviceGetResponseItemInterfaceChannelGroup
{
	/// <summary>
	/// The interface channel group number
	/// </summary> 
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "number")]
	public int Number { get; set; }
}