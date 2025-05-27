namespace Meraki.Api.Data;

/// <summary>
/// Wireless LAN controller associated access point counts
/// </summary>
[DataContract]
public class OrganizationWirelessControllerOverviewByDeviceItemCountsConnections
{
	/// <summary>
	/// Wireless LAN controller associated total access point count
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }

	/// <summary>
	/// Access point counts by their status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "byStatus")]
	public OrganizationWirelessControllerOverviewByDeviceItemCountsConnectionsByStatus ByStatus { get; set; } = new();
}
