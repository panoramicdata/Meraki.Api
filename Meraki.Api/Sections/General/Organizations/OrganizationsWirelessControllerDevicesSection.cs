namespace Meraki.Api.Sections.General.Organizations;

public class OrganizationsWirelessControllerDevicesSection
{
	public OrganizationsWirelessControllerDevicesInterfacesSection Interfaces { get; internal set; } = new();

	public IOrganizationsWirelessControllerDevicesRedundancy Redundancy { get; internal set; } = null!;

	public OrganizationsWirelessControllerDevicesSystemSection System { get; internal set; } = new();
}
