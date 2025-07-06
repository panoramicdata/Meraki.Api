namespace Meraki.Api.Data;

/// <summary>
/// Associated client count on access point
/// </summary>
[DataContract]
public class OrganizationsWirelessControllerClientsOverviewByDeviceItemCounts
{
	/// <summary>
	/// Associated client count on access point by status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "byStatus")]
	public OrganizationsWirelessControllerClientsOverviewByDeviceItemCountsByStatus ByStatus { get; set; } = new();
}
