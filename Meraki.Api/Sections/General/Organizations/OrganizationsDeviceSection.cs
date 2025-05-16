namespace Meraki.Api.Sections.General.Organizations;
public partial class OrganizationsDeviceSection
{
	[RefitPromoteCalls]
	public IOrganizationsDevices Devices { get; internal set; } = null!;
}
