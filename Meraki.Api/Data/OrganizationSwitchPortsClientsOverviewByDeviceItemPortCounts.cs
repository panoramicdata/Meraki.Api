namespace Meraki.Api.Data;

/// <summary>
/// Number of clients on the port in a given time.
/// </summary>
[DataContract]
public class OrganizationSwitchPortsClientsOverviewByDeviceItemPortCounts
{
	/// <summary>
	/// Associated client count on access point by status.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "byStatus")]
	public OrganizationSwitchPortsClientsOverviewByDeviceItemPortCountsByStatus ByStatus { get; set; } = new();
}
