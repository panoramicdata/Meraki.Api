namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Organizations Wireless Controller Clients Overview History
/// </summary>
public class OrganizationsWirelessControllerClientsOverviewHistory
{
	/// <summary>
	/// List wireless client counts of wireless LAN controllers over time in an organization
	/// </summary>

	public IOrganizationsWirelessControllerClientsOverviewHistoryByDevice ByDevice { get; set; } = null!;
}
