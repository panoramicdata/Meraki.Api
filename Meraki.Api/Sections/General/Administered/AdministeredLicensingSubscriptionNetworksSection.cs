using Meraki.Api.Interfaces.General.Administered;

namespace Meraki.Api.Sections.General.Administered;

/// <summary>
/// Provides access to administered licensing subscription networks API endpoints
/// </summary>
public class AdministeredLicensingSubscriptionNetworksSection
{
	/// <summary>
	/// Batch change networks to their desired feature tier for specified product types
	/// </summary>

	public IAdministeredLicensingSubscriptionNetworksFeatureTiers FeatureTiers { get; internal set; } = null!;
}
