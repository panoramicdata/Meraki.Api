namespace Meraki.Api.Interfaces.General.Administered;

public interface IAdministeredLicensingSubscriptionEntitlements
{
	/// <summary>
	/// Retrieve the list of purchasable entitlements
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getAdministeredLicensingSubscriptionEntitlements")]
	[Get("/administered/licensing/subscription/entitlements")]
	Task<AdministeredLicensingSubscriptionEntitlements> GetAdministeredLicensingSubscriptionEntitlementsAsync(CancellationToken cancellationToken = default);
}
