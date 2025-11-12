using Meraki.Api.Interfaces.General.Administered;

namespace Meraki.Api.Sections.General.Administered;

/// <summary>
/// Provides access to administered licensing subscription API endpoints
/// </summary>
public class AdministeredLicensingSubscriptionSection
{
	/// <summary>
	/// Retrieve the list of purchasable entitlements
	/// </summary>

	public IAdministeredLicensingSubscriptionEntitlements Entitlements { get; internal set; } = null!;

	/// <summary>
	/// Return a network
	/// </summary>

	public AdministeredLicensingSubscriptionNetworksSection Networks { get; internal set; } = new();

	/// <summary>
	/// Gets the subscriptions
	/// </summary>

	public AdministeredLicensingSubscriptionSubscriptionsSection Subscriptions { get; internal set; } = new();
}
