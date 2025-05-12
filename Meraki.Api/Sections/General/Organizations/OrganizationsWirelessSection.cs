namespace Meraki.Api.Sections.General.Organizations;
public class OrganizationsWirelessSection
{
	public IOrganizationsWirelessLocationScanning LocationScanning { get; internal set; }

	public IWirelessZigbee Zigbee { get; internal set; }
}
