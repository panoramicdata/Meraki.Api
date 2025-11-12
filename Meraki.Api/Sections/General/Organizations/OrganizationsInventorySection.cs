namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations inventory API endpoints
/// </summary>
public class OrganizationsInventorySection
{
	/// <summary>
	/// Gets the onboarding
	/// </summary>

	public OrganizationsInventoryOnboardingSection Onboarding { get; internal set; } = new();

	/// <summary>
	/// Claim an order by the secure unique order claim number, the order claim id
	/// </summary>

	public IOrganizationsInventoryOrders Orders { get; set; } = null!;
}
