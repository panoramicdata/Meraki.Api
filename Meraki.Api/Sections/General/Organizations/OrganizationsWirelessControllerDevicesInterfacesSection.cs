namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations wireless controller devices interfaces API endpoints
/// </summary>
public class OrganizationsWirelessControllerDevicesInterfacesSection
{
	/// <summary>
	/// List wireless LAN controller layer 2 interfaces in an organization
	/// </summary>

	public IOrganizationsWirelessControllerDevicesInterfacesL2 L2 { get; internal set; } = null!;

	/// <summary>
	/// List wireless LAN controller layer 3 interfaces in an organization
	/// </summary>

	public IOrganizationsWirelessControllerDevicesInterfacesL3 L3 { get; internal set; } = null!;

	/// <summary>
	/// Retrieve the packet counters for the interfaces of a Wireless LAN controller
	/// </summary>

	public IOrganizationsWirelessControllerDevicesInterfacesPackets Packets { get; internal set; } = null!;

	/// <summary>
	/// Retrieve the traffic for the interfaces of a Wireless LAN controller
	/// </summary>

	public IOrganizationsWirelessControllerDevicesInterfacesUsage Usage { get; internal set; } = null!;
}
