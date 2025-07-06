namespace Meraki.Api.Sections.General.Organizations;

public class OrganizationsInventorySection
{
	public OrganizationsInventoryOnboardingSection Onboarding { get; internal set; } = new();

	public IOrganizationsInventoryOrders Orders { get; set; } = null!;
}
