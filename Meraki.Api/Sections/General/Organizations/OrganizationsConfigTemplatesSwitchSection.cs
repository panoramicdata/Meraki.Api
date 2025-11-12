namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations config templates switch API endpoints
/// </summary>
public class OrganizationsConfigTemplatesSwitchSection
{
	/// <summary>
	/// Gets the profiles
	/// </summary>

	public OrganizationsConfigTemplatesSwitchProfilesSection Profiles { get; set; } = new();
}
