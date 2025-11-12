namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations devices power modules API endpoints
/// </summary>
public class OrganizationsDevicesPowerModulesSection
{
	/// <summary>
	/// List the most recent status information for power modules in rackmount MX and MS devices that support them. The data returned by this endpoint is updated every 5 minutes.
	/// </summary>

	public IOrganizationsDevicesPowerModulesStatuses Statuses { get; internal set; } = null!;
}
