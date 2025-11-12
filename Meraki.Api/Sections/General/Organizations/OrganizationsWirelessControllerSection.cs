namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations wireless controller API endpoints
/// </summary>
public partial class OrganizationsWirelessControllerSection
{
	[RefitPromoteCalls]
	internal IOrganizationsWirelessController WirelessController { get; set; } = null!;

	/// <summary>
	/// List of unassigned Catalyst access points and summary information
	/// </summary>

	public IOrganizationsWirelessControllerConnections Connections { get; internal set; } = null!;

	/// <summary>
	/// Gets the clients
	/// </summary>

	public OrganizationsWirelessControllerClientsSection Clients { get; internal set; } = new();

	/// <summary>
	/// Return a single device
	/// </summary>

	public OrganizationsWirelessControllerDevicesSection Devices { get; internal set; } = new();

	/// <summary>
	/// List connectivity data of wireless LAN controllers in an organization. If it is HA setup, then only returns active WLC data start from switchover
	/// </summary>

	public IOrganizationsWirelessControllerAvailabilities Availabilities { get; internal set; } = null!;

	/// <summary>
	/// List the overview information of wireless LAN controllers in an organization and it is updated every minute.
	/// </summary>

	public IOrganizationsWirelessControllerOverview Overview { get; internal set; } = null!;
}
