namespace Meraki.Api.Sections.General.Organizations;

public class OrganizationBrandingPoliciesSection
{
	public IOrganizationsBrandingPolicies BrandingPolicies { get; internal set; } = null!;
	public IOrganizationsBrandingPoliciesPriorities Priorities { get; internal set; } = null!;
}