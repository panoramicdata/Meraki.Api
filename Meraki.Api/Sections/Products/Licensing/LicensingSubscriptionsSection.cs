using Meraki.Api.Interfaces.General.Administered;
using Meraki.Api.Interfaces.Products.Licensing;

namespace Meraki.Api.Sections.Products.Licensing;

/// <summary>
/// Provides access to licensing subscription API endpoints
/// </summary>
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
