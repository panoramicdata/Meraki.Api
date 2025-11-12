namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations wireless controller clients API endpoints
/// </summary>
public class OrganizationsWirelessControllerClientsSection
{
	/// <summary>
	/// Gets the overview
	/// </summary>

	public OrganizationsWirelessControllerClientsOverview Overview { get; internal set; } = new();
}
