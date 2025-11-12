namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations devices system API endpoints
/// </summary>

public partial class OrganizationsDevicesSystemSection
{
	[RefitPromoteCalls]
	internal IOrganizationsDevicesSystem System { get; set; } = null!;

	/// <summary>
	/// Gets the memory
	/// </summary>

	public OrganizationsDevicesSystemMemorySection Memory { get; internal set; } = new();
}
