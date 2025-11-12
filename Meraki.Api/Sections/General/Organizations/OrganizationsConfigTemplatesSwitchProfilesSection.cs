namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations config templates switch profiles API endpoints
/// </summary>
public class OrganizationsConfigTemplatesSwitchProfilesSection
{
	/// <summary>
	/// Gets the ports
	/// </summary>

	public OrganizationsConfigTemplatesSwitchProfilesPortsSection Ports { get; set; } = new();
}
