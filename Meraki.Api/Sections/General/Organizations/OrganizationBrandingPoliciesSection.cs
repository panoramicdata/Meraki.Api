namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organization branding policies API endpoints
/// </summary>

public partial class OrganizationBrandingPoliciesSection
{
	[RefitPromoteCalls]
	internal IOrganizationsBrandingPolicies BrandingPolicies { get; set; } = null!;
	/// <summary>
	/// Return the branding policy IDs of an organization in priority order
	/// </summary>

	public IOrganizationsBrandingPoliciesPriorities Priorities { get; internal set; } = null!;
}
