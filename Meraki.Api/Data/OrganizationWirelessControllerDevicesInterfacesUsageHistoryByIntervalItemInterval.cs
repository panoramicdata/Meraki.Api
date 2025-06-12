namespace Meraki.Api.Data;

/// <summary>
/// Time interval snapshot of interfaces usage data of the wireless LAN controller
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesUsageHistoryByIntervalItemInterval
{
	/// <summary>
	/// The end time interval snapshots of the query range with iso8601 format
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "endTs")]
	public string EndTs { get; set; } = string.Empty;

	/// <summary>
	/// The start time interval snapshots of the query range with iso8601 format
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "startTs")]
	public string StartTs { get; set; } = string.Empty;

	/// <summary>
	/// The overall usage of all queried interfaces of the wireless LAN controller
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "overall")]
	public OrganizationWirelessControllerDevicesInterfacesUsageHistoryByIntervalItemIntervalOverall Overall { get; set; } = new();

	/// <summary>
	/// The usage data on the interfaces of the wireless LAN controller
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "byInterface")]
	public List<OrganizationWirelessControllerDevicesInterfacesUsageHistoryByIntervalItemIntervalByInterfaceItem> ByInterface { get; set; } = [];
}
