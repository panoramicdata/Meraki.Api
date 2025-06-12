namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Controller Clients Overview History By Device By Interval
/// </summary>
[DataContract]
public class OrganizationWirelessControllerClientsOverviewHistoryByDeviceByInterval
{
	/// <summary>
	/// Metadata relevant to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationWirelessControllerClientsOverviewHistoryByDeviceByIntervalMetadata Meta { get; set; } = new();

	/// <summary>
	/// Overview history of wireless LAN controllers
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public List<OrganizationWirelessControllerClientsOverviewHistoryByDeviceByIntervalItem> Items { get; set; } = [];
}
