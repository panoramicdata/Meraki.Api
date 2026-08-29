namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organization branding policies API endpoints
/// </summary>

// Codacy analyses each file on its own, so it cannot see the other parts of this class and reports
// 'partial' as gratuitous (S2333). Both are false positives: the remaining parts are emitted by
// RefitClassSourceGenerator, or live in the sibling MerakiClient files.
#pragma warning disable S2333
public partial class OrganizationBrandingPoliciesSection
{
	[RefitPromoteCalls]
	internal IOrganizationsBrandingPolicies BrandingPolicies { get; set; } = null!;
	/// <summary>
	/// Return the branding policy IDs of an organization in priority order
	/// </summary>

	public IOrganizationsBrandingPoliciesPriorities Priorities { get; internal set; } = null!;
}
#pragma warning restore S2333
