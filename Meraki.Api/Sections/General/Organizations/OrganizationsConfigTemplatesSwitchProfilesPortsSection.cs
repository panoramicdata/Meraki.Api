namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations config templates switch profiles ports API endpoints
/// </summary>
public class OrganizationsConfigTemplatesSwitchProfilesPortsSection
{
	/// <summary>
	/// List the port mirror configurations in an organization by switch profile
	/// </summary>

	public IOrganizationsConfigTemplatesSwitchProfilesPortsMirrors Mirrors { get; internal set; } = null!;
}
