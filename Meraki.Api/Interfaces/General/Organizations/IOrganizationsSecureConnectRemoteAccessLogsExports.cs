namespace Meraki.Api.Interfaces.General.Organizations;
/// <summary>
/// I Organizations Secure Connect Remote Access Logs Exports
/// </summary>
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
	/// Return the details of a specific remote access logs export
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSecureConnectRemoteAccessLogsExport")]
	[Get("/organizations/{organizationId}/secureConnect/remoteAccessLogsExports/{id}")]
	Task<SecureConnectRemoteAccessLogsExportsResponseDataItem> GetOrganizationSecureConnectRemoteAccessLogsExportAsync(
		string organizationId,
		string id,
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

	/// <summary>
	/// Redirects to the download link of the completed export.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSecureConnectRemoteAccessLogsExportsDownload")]
	[Get("/organizations/{organizationId}/secureConnect/remoteAccessLogsExports/download")]
	Task<SecureConnectRemoteAccessLogsExportDownload> GetOrganizationSecureConnectRemoteAccessLogsExportsDownloadAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
