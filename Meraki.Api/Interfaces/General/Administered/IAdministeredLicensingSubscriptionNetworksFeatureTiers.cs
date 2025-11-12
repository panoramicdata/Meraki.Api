namespace Meraki.Api.Interfaces.General.Administered;
/// <summary>
/// I Administered Licensing Subscription Networks Feature Tiers
/// </summary>
public interface IAdministeredLicensingSubscriptionNetworksFeatureTiers
{
	/// <summary>
	/// Batch change networks to their desired feature tier for specified product types
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("batchAdministeredLicensingSubscriptionNetworksFeatureTiersUpdate")]
	[Post("/administered/licensing/subscription/networks/featureTiers/batchUpdate")]
	Task<AdministeredLicensingSubscriptionNetworksFeatureTiersUpdateResponse> BatchAdministeredLicensingSubscriptionNetworksFeatureTiersUpdateAsync(
		[Body] AdministeredLicensingSubscriptionNetworksFeatureTiersUpdateRequest request,
		CancellationToken cancellationToken = default
	);
}
