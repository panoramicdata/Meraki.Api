using Meraki.Api.Interfaces.General.Administered;
using Meraki.Api.Interfaces.Products.Licensing;

namespace Meraki.Api.Sections.Products.Licensing;

/// <summary>
/// Provides access to licensing subscription API endpoints
/// </summary>
public partial class LicensingSubscriptionsSection
{
	[RefitPromoteCalls]
	internal ILicensingSubscriptions Subscriptions { get; set; } = null!;

	/// <summary>
	/// Retrieve the list of purchasable entitlements
	/// </summary>

	public IAdministeredLicensingSubscriptionEntitlements Entitlements { get; internal set; } = null!;
}
