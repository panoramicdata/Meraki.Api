using Meraki.Api.Interfaces.General.Administered;
using Meraki.Api.Interfaces.Products.Licensing;

namespace Meraki.Api.Sections.Products.Licensing;

/// <summary>
/// Provides access to licensing subscription API endpoints
/// </summary>
// Codacy analyses each file on its own, so it cannot see the other parts of this class and reports
// 'partial' as gratuitous (S2333). That is a false positive: the remaining part is emitted by
// RefitClassSourceGenerator.
#pragma warning disable S2333
public partial class LicensingSubscriptionsSection : ILicensingSubscriptions
{
	[RefitPromoteCalls]
	internal ILicensingSubscriptions Subscriptions { get; set; } = null!;

	/// <summary>
	/// Retrieve the list of purchasable entitlements
	/// </summary>

	public IAdministeredLicensingSubscriptionEntitlements Entitlements { get; internal set; } = null!;

	/// <inheritdoc />
	Task<ApiResponse<List<LicensingSubscriptionSubscription>>> ILicensingSubscriptions.GetAdministeredLicensingSubscriptionSubscriptionsApiResponseAsync(
		string? startingAfter,
		string? endingBefore,
		List<string>? subscriptionIds,
		List<string>? organizationIds,
		List<string>? statuses,
		List<string>? productTypes,
		List<string>? skus,
		string? startDate,
		string? endDate,
		CancellationToken cancellationToken)
		=> Subscriptions.GetAdministeredLicensingSubscriptionSubscriptionsApiResponseAsync(
			startingAfter,
			endingBefore,
			subscriptionIds,
			organizationIds,
			statuses,
			productTypes,
			skus,
			startDate,
			endDate,
			cancellationToken);
}
#pragma warning restore S2333
