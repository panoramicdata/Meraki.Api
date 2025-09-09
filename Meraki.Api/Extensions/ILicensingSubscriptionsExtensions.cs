using Meraki.Api.Interfaces.Products.Licensing;

namespace Meraki.Api.Extensions;

public static class ILicensingSubscriptionsExtensions
{
	/// <summary>
	/// List available subscriptions
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="licensingSubscriptions"></param>
	/// <param name="subscriptionIds">List of subscription ids to fetch</param>
	/// <param name="organizationIds">Organizations to get associated subscriptions for</param>
	/// <param name="statuses">List of statuses that returned subscriptions can have</param>
	/// <param name="productTypes">List of product types that returned subscriptions need to have entitlements for.</param>
	/// <param name="startDate">Filter subscriptions by start date, ISO 8601 format. To filter with a range of dates, use 'startDate[]=?' in the request. Accepted options include lt, gt, lte, gte.</param>
	/// <param name="endDate">Filter subscriptions by end date, ISO 8601 format. To filter with a range of dates, use 'endDate[]=?' in the request. Accepted options include lt, gt, lte, gte.</param>
	/// <param name="cancellationToken"></param>
	public static Task<List<LicensingSubscriptionSubscription>> GetAdministeredLicensingSubscriptionSubscriptionsAllAsync(
		this ILicensingSubscriptions licensingSubscriptions,
		List<string>? subscriptionIds,
		List<string>? organizationIds,
		List<string>? statuses,
		List<string>? productTypes,
		List<string>? skus,
		string? startDate,
		string? endDate,
		CancellationToken cancellationToken = default)
		=> MerakiClient.GetAllAsync(
				(startingAfter, endingBefore, cancellationToken)
				=> licensingSubscriptions.GetAdministeredLicensingSubscriptionSubscriptionsApiResponseAsync(
						startingAfter,
						endingBefore,
						subscriptionIds,
						organizationIds,
						statuses,
						productTypes,
						skus,
						startDate,
						endDate,
						cancellationToken
					),
					cancellationToken
			);
}
