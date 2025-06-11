using Meraki.Api.Interfaces.General.Administered;

namespace Meraki.Api.Sections.General.Administered;

public class AdministeredLicensingSubscriptionSection
{
	public IAdministeredLicensingSubscriptionEntitlements Entitlements { get; internal set; } = null!;

	public AdministeredLicensingSubscriptionNetworksSection Networks { get; internal set; } = new();

	public AdministeredLicensingSubscriptionSubscriptionsSection Subscriptions { get; internal set; } = new();
}