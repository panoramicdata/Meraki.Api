namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations devices system memory API endpoints
/// </summary>
public class OrganizationsDevicesSystemMemorySection
{
	/// <summary>
	/// Gets the usage
	/// </summary>

	public OrganizationsDevicesSystemMemoryUsageSection Usage { get; set; } = new();
}
