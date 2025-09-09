namespace Meraki.Api.Interfaces.Products.Licensing;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ILicensingSubscriptions
{
	/// <summary>
	/// Claim a subscription into an organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="licensingSubscriptionClaimRequest">The subscription to be claimed</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("claimAdministeredLicensingSubscriptionSubscriptions")]
	[Post("/administered/licensing/subscription/subscriptions/claim")]
	Task<LicensingSubscriptionClaim> ClaimAdministeredLicensingSubscriptionSubscriptionsAsync(
		[Body] LicensingSubscriptionClaimRequest licensingSubscriptionClaimRequest,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Bind networks to a subscription
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="subscriptionId">Subscription ID</param>
	/// <param name="licensingSubscriptionBindRequest">The subscription to be claimed</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("bindAdministeredLicensingSubscriptionSubscription")]
	[Post("/administered/licensing/subscription/subscriptions/{subscriptionId}/bind")]
	Task<LicensingSubscriptionBindings> BindAdministeredLicensingSubscriptionSubscriptionAsync(
		string subscriptionId,
		[Body] LicensingSubscriptionBindRequest licensingSubscriptionBindRequest,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// List available subscriptions
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 1000.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="subscriptionIds">List of subscription ids to fetch</param>
	/// <param name="organizationIds">Organizations to get associated subscriptions for</param>
	/// <param name="statuses">List of statuses that returned subscriptions can have</param>
	/// <param name="productTypes">List of product types that returned subscriptions need to have entitlements for.</param>
	/// <param name="skus">List of SKUs that returned subscriptions need to have entitlements for.</param>
	/// <param name="startDate">Filter subscriptions by start date, ISO 8601 format. To filter with a range of dates, use 'startDate[]=?' in the request. Accepted options include lt, gt, lte, gte.</param>
	/// <param name="endDate">Filter subscriptions by end date, ISO 8601 format. To filter with a range of dates, use 'endDate[]=?' in the request. Accepted options include lt, gt, lte, gte.</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getAdministeredLicensingSubscriptionSubscriptions")]
	[Get("/administered/licensing/subscription/subscriptions")]
	Task<List<LicensingSubscriptionSubscription>> GetAdministeredLicensingSubscriptionSubscriptionsAsync(
		int? perPage = 1000,
		string startingAfter = null!,
		string endingBefore = null!,
		[AliasAs("subscriptionIds[]")] List<string> subscriptionIds = null!,
		[AliasAs("organizationIds[]")] List<string> organizationIds = null!,
		[AliasAs("statuses[]")] List<string> statuses = null!,
		[AliasAs("productTypes[]")] List<string> productTypes = null!,
		[AliasAs("skus[]")] List<string> skus = null!,
		string startDate = null!,
		string endDate = null!,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// For use by GetAdministeredLicensingSubscriptionSubscriptionsAllAsync
	/// </summary>
	[Get("/administered/licensing/subscription/subscriptions")]
	internal Task<ApiResponse<List<LicensingSubscriptionSubscription>>> GetAdministeredLicensingSubscriptionSubscriptionsApiResponseAsync(
		string? startingAfter,
		string? endingBefore,
		[AliasAs("subscriptionIds[]")] List<string>? subscriptionIds,
		[AliasAs("organizationIds[]")] List<string>? organizationIds,
		[AliasAs("statuses[]")] List<string>? statuses,
		[AliasAs("productTypes[]")] List<string>? productTypes,
		[AliasAs("skus[]")] List<string>? skus,
		string? startDate,
		string? endDate,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Find a subscription by claim key. Returns 400 if the key has already been claimed.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="licensingClaimKeyValidationRequest">The Claim Key validation request</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("validateAdministeredLicensingSubscriptionSubscriptionsClaimKey")]
	[Post("/administered/licensing/subscription/subscriptions/claimKey/validate")]
	Task<LicensingClaimKeyValidation> ValidateAdministeredLicensingSubscriptionSubscriptionsClaimKey(
		[Body] LicensingClaimKeyValidationRequest licensingClaimKeyValidationRequest,
		CancellationToken cancellationToken = default
		);
}
