namespace Meraki.Api.Sections.General.Organizations;

public class OrganizationsWirelessControllerDevicesInterfacesSection
{
	public IOrganizationsWirelessControllerDevicesInterfacesL2 L2 { get; internal set; } = null!;

	public IOrganizationsWirelessControllerDevicesInterfacesL3 L3 { get; internal set; } = null!;
}