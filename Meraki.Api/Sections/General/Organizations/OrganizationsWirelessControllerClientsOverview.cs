namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Organizations Wireless Controller Clients Overview
/// </summary>
public class OrganizationsWirelessControllerClientsOverview
{
	/// <summary>
	/// Gets the history
	/// </summary>

	public OrganizationsWirelessControllerClientsOverviewHistory History { get; internal set; } = new();
}
