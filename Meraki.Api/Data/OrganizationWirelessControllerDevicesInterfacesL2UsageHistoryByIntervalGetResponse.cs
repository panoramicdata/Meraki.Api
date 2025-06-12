namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Controller Devices Interfaces L2 Usage History By Interval Get Response
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesL2UsageHistoryByIntervalGetResponse
{
	/// <summary>
	/// Metadata relevant to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public OrganizationWirelessControllerDevicesInterfacesL2GetResponseMetadata Meta { get; set; } = new();

	/// <summary>
	/// Wireless LAN controller layer 2 interfaces usage
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationWirelessControllerDevicesInterfacesL2UsageHistoryByIntervalGetResponseItem> Items { get; set; } = [];
}
