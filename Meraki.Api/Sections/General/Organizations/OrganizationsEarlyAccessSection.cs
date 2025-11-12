namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations early access API endpoints
/// </summary>
public class OrganizationsEarlyAccessSection
{
	/// <summary>
	/// List the available early access features for organization
	/// </summary>

	public IOrganizationsEarlyAccessFeatures Features { get; internal set; } = null!;
}
