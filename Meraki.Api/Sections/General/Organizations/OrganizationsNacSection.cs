namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations nac API endpoints
/// </summary>
public class OrganizationsNacSection
{
	/// <summary>
	/// Get all nac authorization policy sets for this organization
	/// </summary>

	public IOrganizationsNacAuthorization Authorization { get; internal set; } = null!;

	/// <summary>
	/// List the NAC Sessions for this organization
	/// </summary>

	public IOrganizationsNacSessions Sessions { get; internal set; } = null!;
}
