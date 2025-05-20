namespace Meraki.Api.Sections.General.Organizations;

public class OrganizationsWirelessDevicesSection
{
	public IOrganizationsWirelessDevicesLatency Latency { get; internal set; } = null!;

	public IOrganizationsWirelessRadio Radio { get; internal set; } = null!;
}