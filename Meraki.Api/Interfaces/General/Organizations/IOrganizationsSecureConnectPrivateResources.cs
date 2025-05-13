namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsSecureConnectPrivateResources
{
	/// <summary>
	/// Provides a list of private resources for an organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSecureConnectPrivateResources")]
	[Get("/organizations/{organizationId}/secureConnect/privateResources")]
	Task<SecureConnectPrivateResourcesResponse> GetOrganizationSecureConnectPrivateResourcesAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
