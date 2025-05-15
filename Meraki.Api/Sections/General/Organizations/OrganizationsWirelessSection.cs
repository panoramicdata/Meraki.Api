namespace Meraki.Api.Sections.General.Organizations;
public class OrganizationsWirelessSection
{
	public IOrganizationsWirelessLocationScanning LocationScanning { get; internal set; } = null!;

	public IWirelessZigbee Zigbee { get; internal set; } = null!;

	public OrganizationsWirelessDevicesSection Devices { get; internal set; } = new();
}
