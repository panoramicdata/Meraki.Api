namespace Meraki.Api.Sections.General.Organizations;

public partial class OrganizationsDevicesSystemSection
{
	[RefitPromoteCalls]
	internal IOrganizationsDevicesSystem System { get; set; }

	public OrganizationsDevicesSystemMemorySection Memory { get; internal set; } = new();
}
