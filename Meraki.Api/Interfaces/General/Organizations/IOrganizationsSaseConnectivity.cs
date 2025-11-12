namespace Meraki.Api.Interfaces.General.Organizations;
/// <summary>
/// I Organizations Sase Connectivity
/// </summary>
public interface IOrganizationsSaseConnectivity
{
	/// <summary>
	/// List of MX networks or templates that can be enrolled into Secure Access
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSaseConnectivityEnrollableNetworks")]
	[Get("/organizations/{organizationId}/sase/connectivity/enrollableNetworks")]
	Task<OrganizationsSaseConnectivityEnrollableNetworkResponse> GetOrganizationSaseConnectivityEnrollableNetworksAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Get details of a site in this organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSaseConnectivitySite")]
	[Get("/organizations/{organizationId}/sase/connectivity/sites/{id}")]
	Task<OrganizationsSaseConnectivityEnrollableNetwork> GetOrganizationSaseConnectivitySiteAsync(
		string organizationId,
		string id,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Enroll sites in this organization to Secure Access. For an organization, a maximum of 4000 sites can be enrolled if they are in spoke mode or a maximum of 10 sites can be enrolled in hub mode.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createOrganizationSaseConnectivitySitesBulkEnroll")]
	[Post("/organizations/{organizationId}/sase/connectivity/sites/bulkEnroll")]
	Task<OrganizationsSaseConnectivityEnrollableNetworkBulkEnrollResponse> CreateOrganizationSaseConnectivitySitesBulkEnrollAsync(
		string organizationId,
		[Body] OrganizationsSaseConnectivityEnrollableNetworkBulkEnrollRequest request,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Detach sites in this organization from Secure Access. This will remove the sites from Secure Access.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("deleteOrganizationSaseConnectivitySitesBulkDetach")]
	[Delete("/organizations/{organizationId}/sase/connectivity/sites/bulkDetach")]
	Task<OrganizationsSaseConnectivityEnrollableNetworkBulkDetachResponse> DeleteOrganizationSaseConnectivitySitesBulkDetachAsync(
		string organizationId,
		[Body] OrganizationsSaseConnectivityEnrollableNetworkBulkDetachRequest request,
		CancellationToken cancellationToken = default
	);
}
