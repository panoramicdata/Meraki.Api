namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// I Organizations Campus Gateway Clusters
/// </summary>
public interface IOrganizationsCampusGatewayClusters
{
	/// <summary>
	/// Get the details of campus gateway clusters
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationCampusGatewayClusters")]
	[Get("/organizations/{organizationId}/campusGateway/clusters")]
	Task<List<OrganizationCampusGatewayCluster>> GetOrganizationCampusGatewayClustersAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
