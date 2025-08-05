namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsSecureConnectRemoteAccessLog
{
	/// <summary>
	/// List the latest 5000 events logged by remote access.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSecureConnectRemoteAccessLog")]
	[Get("/organizations/{organizationId}/secureConnect/remoteAccessLog")]
	Task<OrganizationSecureConnectRemoteAccessLog> GetOrganizationSecureConnectRemoteAccessLogAsync(string organizationId, CancellationToken cancellationToken = default);
}
