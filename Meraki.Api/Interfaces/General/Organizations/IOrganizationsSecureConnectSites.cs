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
	Task<ApiResponse<SecureConnectSitesResponse>> GetOrganizationSecureConnectSitesAsync(
		string organizationId,
		int? perPage = 10,
		string? startingAfter = null,
		string? endingBefore = null,
		// TODO RH Two further properties to be implemented
		CancellationToken cancellationToken = default
	);

	[ApiOperationId("getOrganizationSecureConnectSites")]
	[Get("/organizations/{organizationId}/secureConnect/sites")]
	internal Task<ApiResponse<SecureConnectSitesResponse>> GetOrganizationSecureConnectSitesApiResponseAsync(
		string organizationId,
		string? startingAfter = null,
		string? endingBefore = null,
		// TODO RH Two further properties to be implemented
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Enroll sites in this organization to Secure Connect. For an organization, a maximum of 4000 sites can be enrolled if they are in spoke mode or a maximum of 10 sites can be enrolled in hub mode.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="secureConnectSite"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createOrganizationSecureConnectSite")]
	[Post("/organizations/{organizationId}/secureConnect/sites")]
	Task<SecureConnectSiteCreateResponse> CreateOrganizationSecureConnectSiteAsync(
		string organizationId,
		[Body] SecureConnectSiteCreateRequest secureConnectSite,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Detach given sites from Secure Connect
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="secureConnectSite"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("deleteOrganizationSecureConnectSite")]
	[Delete("/organizations/{organizationId}/secureConnect/sites")]
	Task<SecureConnectSiteDeleteResponse> DeleteOrganizationSecureConnectSiteAsync(
		string organizationId,
		[Body] SecureConnectSiteDeleteRequest secureConnectSite,
		CancellationToken cancellationToken = default
	);
}
