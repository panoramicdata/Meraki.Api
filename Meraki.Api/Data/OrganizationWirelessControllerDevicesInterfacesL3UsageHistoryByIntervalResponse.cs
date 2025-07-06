namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Controller Devices Interfaces L3 Usage History By Interval Response
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesL3UsageHistoryByIntervalResponse
{
	/// <summary>
	/// Metadata relevant to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationWirelessControllerDevicesInterfaceL3ByDeviceMetadata Meta { get; set; } = new();

	/// <summary>
	/// Wireless LAN controller layer 3 interfaces usage
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationWirelessControllerDevicesInterfacesL3UsageHistoryByIntervalItem> Items { get; set; } = [];
}
