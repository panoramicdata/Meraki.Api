namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Controller Devices Interfaces L2 By Device Get Response
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesL2ByDeviceGetResponse
{
	/// <summary>
	/// Metadata relevant to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationWirelessControllerDevicesInterfacesL2GetResponseMetadata Meta { get; set; } = new();

	/// <summary>
	/// Wireless LAN controller L2 interfaces
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationWirelessControllerDevicesInterfacesL2ByDeviceGetResponseItem> Items { get; set; } = [];
}
