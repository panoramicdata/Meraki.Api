namespace Meraki.Api.Sections.General.Organizations;

public partial class OrganizationBrandingPoliciesSection
{
	[RefitPromoteCalls]
	internal IOrganizationsBrandingPolicies BrandingPolicies { get; set; } = null!;
	public IOrganizationsBrandingPoliciesPriorities Priorities { get; internal set; } = null!;
}