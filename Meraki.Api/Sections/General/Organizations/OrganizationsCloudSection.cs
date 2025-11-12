namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations cloud API endpoints
/// </summary>
public class OrganizationsCloudSection
{
	/// <summary>
	/// List of source/destination traffic rules
	/// </summary>

	public IOrganizationsCloudConnectivity Connectivity { get; internal set; } = null!;
}
