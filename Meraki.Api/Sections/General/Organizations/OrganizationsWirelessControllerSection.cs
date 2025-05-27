namespace Meraki.Api.Sections.General.Organizations;
public partial class OrganizationsWirelessControllerSection
{
	[RefitPromoteCalls]
	internal IOrganizationsWirelessController WirelessController { get; set; } = null!;

	public OrganizationsWirelessControllerDevicesSection Devices { get; internal set; } = new();

	public IOrganizationsWirelessControllerAvailabilities Availabilities { get; internal set; } = null!;

	public IOrganizationsWirelessControllerOverview Overview { get; internal set; } = null!;
}
