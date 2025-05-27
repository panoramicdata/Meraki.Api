namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Controller Devices Interfaces Usage History By Interval
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesUsageHistoryByInterval
{
	/// <summary>
	/// Metadata relevant to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationWirelessControllerDevicesInterfacesUsageHistoryByIntervalMetadata Meta { get; set; } = new();

	/// <summary>
	/// Wireless LAN controller interfaces usage data
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationWirelessControllerDevicesInterfacesUsageHistoryByIntervalItem> Items { get; set; } = [];
}
