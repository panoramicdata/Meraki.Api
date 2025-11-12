namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations devices system memory usage API endpoints
/// </summary>
public class OrganizationsDevicesSystemMemoryUsageSection
{
	/// <summary>
	/// Return the memory utilization history in kB for devices in the organization.
	/// </summary>

	public IOrganizationsDevicesSystemMemoryUsageHistory History { get; internal set; } = null!;
}
