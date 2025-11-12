namespace Meraki.Api.Interfaces.General.Administered;
/// <summary>
/// I Administered Licensing Subscription Subscriptions Compliance
/// </summary>
public interface IAdministeredLicensingSubscriptionSubscriptionsCompliance
{
	/// <summary>
	/// Get compliance status for requested subscriptions
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getAdministeredLicensingSubscriptionSubscriptionsComplianceStatuses")]
	[Get("/administered/licensing/subscription/subscriptions/compliance/statuses")]
	Task<AdministeredLicensingSubscriptionSubscriptionsComplianceStatuses> GetAdministeredLicensingSubscriptionSubscriptionsComplianceStatusesAsync(
		string networkId,
		CancellationToken cancellationToken = default
	);
}
