namespace Meraki.Api.Data;

/// <summary>
/// Client counts
/// </summary>
[DataContract]
public class OrganizationWirelessControllerClientsOverviewHistoryByDeviceByIntervalItemReadingCounts
{
	/// <summary>
	/// Client counts by its status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "byStatus")]
	public OrganizationWirelessControllerClientsOverviewHistoryByDeviceByIntervalItemReadingCountsByStatus ByStatus { get; set; } = new();
}
