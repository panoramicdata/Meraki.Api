namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// I Organizations Secure Connect Sites
/// </summary>
public interface IOrganizationsSecureConnectSites
{
	/// <summary>
	/// List sites in this organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 10.</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it.</param>
	/// <param name="search">If provided, filters results by search string</param>
	/// <param name="enrolledState">Filter results by sites that have already been enrolled or can be enrolled. Acceptable values are 'enrolled' or 'enrollable'</param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSecureConnectSites")]
	[Get("/organizations/{organizationId}/secureConnect/sites")]
	Task<SecureConnectSitesResponse> GetOrganizationSecureConnectSitesAsync(
		string organizationId,
		int? perPage = 1000,
		string? startingAfter = null,
		string? endingBefore = null,
		string? search = null,
		string? enrolledState = null,
		CancellationToken cancellationToken = default
	);

	[ApiOperationId("getOrganizationSecureConnectSites")]
	[Get("/organizations/{organizationId}/secureConnect/sites")]
	internal Task<ApiResponse<SecureConnectSitesResponse>> GetOrganizationSecureConnectSitesApiResponseAsync(
		string organizationId,
		int? perPage = 1000,
		string? startingAfter = null,
		string? endingBefore = null,
		string? search = null,
		string? enrolledState = null,
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
