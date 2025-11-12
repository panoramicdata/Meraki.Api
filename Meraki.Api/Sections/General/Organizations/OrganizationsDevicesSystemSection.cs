namespace Meraki.Api.Sections.General.Organizations;

public partial class OrganizationsDevicesSystemSection
{
	[RefitPromoteCalls]
	internal IOrganizationsDevicesSystem System { get; set; } = null!;

	/// <summary>
	/// Gets the memory
	/// </summary>

	public OrganizationsDevicesSystemMemorySection Memory { get; internal set; } = new();
}
