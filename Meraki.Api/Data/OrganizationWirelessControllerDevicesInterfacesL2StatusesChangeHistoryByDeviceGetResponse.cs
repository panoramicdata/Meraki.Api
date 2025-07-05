namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Controller Devices Interfaces L2 Statuses Change History By Device Get Response
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesL2StatusesChangeHistoryByDeviceGetResponse
{
	/// <summary>
	/// Metadata relevant to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationWirelessControllerDevicesInterfacesL2GetResponseMetadata Meta { get; set; } = new();

	/// <summary>
	/// Wireless LAN controller layer 2 interfaces historical status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public List<OrganizationWirelessControllerDevicesInterfacesL2StatusesChangeHistoryByDeviceGetResponseItem> Items { get; set; } = [];
}
