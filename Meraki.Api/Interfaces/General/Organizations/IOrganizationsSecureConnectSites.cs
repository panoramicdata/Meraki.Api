namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsSecureConnectSites
{
	/// <summary>
	/// List sites in this organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSecureConnectSites")]
	[Get("/organizations/{organizationId}/secureConnect/sites")]
	Task<SecureConnectSitesResponse> GetSecureConnectSitesAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
