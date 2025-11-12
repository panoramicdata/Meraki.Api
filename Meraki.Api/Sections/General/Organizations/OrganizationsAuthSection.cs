namespace Meraki.Api.Sections.General.Organizations;
/// <summary>
/// Provides access to organizations auth API endpoints
/// </summary>
public class OrganizationsAuthSection
{
	/// <summary>
	/// List the organization-wide RADIUS servers in the organization
	/// </summary>

	public IOrganizationsAuthRadius Radius { get; internal set; } = null!;
}
