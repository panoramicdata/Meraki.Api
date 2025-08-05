namespace Meraki.Api.Sections.General.Organizations;
public class OrganizationsWirelessSection
{
	public IOrganizationsWirelessLocationScanning LocationScanning { get; internal set; } = null!;

	public IOrganizationsWirelessZigbee Zigbee { get; internal set; } = null!;

	public IOrganizationsWirelessClients Clients { get; internal set; } = null!;

	public OrganizationsWirelessCertificatesSection Certificates { get; set; } = new();

	public OrganizationsWirelessDevicesSection Devices { get; internal set; } = new();

	public IOrganizationsWirelessOpportunisticPcap OpportunisticPcap { get; internal set; } = null!;

	public OrganizationsWirelessSsidsSection Ssids { get; internal set; } = new();
}
