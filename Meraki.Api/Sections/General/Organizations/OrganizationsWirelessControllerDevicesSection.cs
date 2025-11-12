namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations wireless controller devices API endpoints
/// </summary>
public class OrganizationsWirelessControllerDevicesSection
{
	/// <summary>
	/// Gets the interfaces
	/// </summary>

	public OrganizationsWirelessControllerDevicesInterfacesSection Interfaces { get; internal set; } = new();

	/// <summary>
	/// List the failover events of wireless LAN controllers in an organization
	/// </summary>

	public IOrganizationsWirelessControllerDevicesRedundancy Redundancy { get; internal set; } = null!;

	/// <summary>
	/// Gets the system
	/// </summary>

	public OrganizationsWirelessControllerDevicesSystemSection System { get; internal set; } = new();
}
