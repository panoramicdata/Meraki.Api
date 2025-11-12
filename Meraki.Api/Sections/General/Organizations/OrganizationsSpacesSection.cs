namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations spaces API endpoints
/// </summary>
public class OrganizationsSpacesSection
{
	/// <summary>
	/// Get the status of the Spaces integration in Meraki
	/// </summary>

	public IOrganizationsSpacesIntegration Integration { get; internal set; } = null!;
}
