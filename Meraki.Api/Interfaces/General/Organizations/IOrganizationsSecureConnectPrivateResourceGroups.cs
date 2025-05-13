namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsSecureConnectPrivateResourceGroups
{
	/// <summary>
	/// Provides a list of the private resource groups in an organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSecureConnectPrivateResourceGroups")]
	[Get("/organizations/{organizationId}/secureConnect/privateResourceGroups")]
	Task<SecureConnectPrivateResourceGroupsResponse> GetOrganizationSecureConnectPrivateResourceGroupsAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
