namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsSecureConnectRemoteAccessLogsExports
{
	/// <summary>
	/// Provides a list of remote access logs exports for an Organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSecureConnectRemoteAccessLogsExports")]
	[Get("/organizations/{organizationId}/secureConnect/remoteAccessLogsExports")]
	Task<SecureConnectRemoteAccessLogsExportsResponse> GetOrganizationSecureConnectRemoteAccessLogsExportsAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
