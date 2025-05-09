namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsSecureConnectPrivateApplicationGroups
{
	/// <summary>
	/// Provides a list of private application groups for an Organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSecureConnectPrivateApplicationGroups")]
	[Get("/organizations/{organizationId}/secureConnect/privateApplicationGroups")]
	Task<SecureConnectPrivateAppplicationGroups> GetOrganizationSecureConnectPrivateApplicationGroupsAsync(string organizationId, CancellationToken cancellationToken = default);
}
