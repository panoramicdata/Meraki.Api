namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations inventory onboarding API endpoints
/// </summary>
public class OrganizationsInventoryOnboardingSection
{
	/// <summary>
	/// Imports event logs related to the onboarding app into elastisearch
	/// </summary>

	public IOrganizationsInventoryOnboardingCloudMonitoring CloudMonitoring { get; internal set; } = null!;
}
