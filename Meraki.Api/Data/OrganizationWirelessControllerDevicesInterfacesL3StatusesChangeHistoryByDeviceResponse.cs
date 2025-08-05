namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Controller Devices Interfaces L3 Statuses Change History By Device Response
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesL3StatusesChangeHistoryByDeviceResponse
{
	/// <summary>
	/// Metadata relevant to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationWirelessControllerDevicesInterfaceL3ByDeviceMetadata Meta { get; set; } = new();

	/// <summary>
	/// Wireless LAN controller layer 3 interfaces historical status
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationWirelessControllerDevicesInterfacesL3StatusesChangeHistoryByDeviceItem> Items { get; set; } = [];
}
