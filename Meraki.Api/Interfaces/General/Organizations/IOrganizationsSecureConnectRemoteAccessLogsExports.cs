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

	/// <summary>
	/// Creates a export for a provided timestamp interval.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createOrganizationSecureConnectRemoteAccessLogsExport")]
	[Post("/organizations/{organizationId}/secureConnect/remoteAccessLogsExports")]
	Task<SecureConnectRemoteAccessLogsExportsResponseDataItem> CreateOrganizationSecureConnectRemoteAccessLogsExportAsync(
		string organizationId,
		SecureConnectRemoteAccessLogsExportsCreateRequest request,
		CancellationToken cancellationToken = default
	);
}
