namespace Meraki.Api.Interfaces.General.Networks;
public interface INetworksCampusGateway
{
	/// <summary>
	/// Create a cluster and add campus gateways to it
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The Network ID</param>
	/// <param name="campusGatewayClusterCreateRequest">Campus Gateway Cluster Request</param>
	/// <param name="cancellationToken">Cancellation Token</param>
	/// <returns></returns>
	[ApiOperationId("createCampusGatewayCluster")]
	[Post("/networks/{networkId}/campusGateway/clusters")]
	public Task<NetworksCampusGatewayCluster> CreateCampusGatewayClusterAsync(
		string networkId,
		[Body] NetworksCampusGatewayClusterCreateRequest campusGatewayClusterCreateRequest,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Update a cluster and add/remove campus gateways to/from it
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The Network ID</param>
	/// <param name="clusterId">The Cluster ID</param>
	/// <param name="campusGatewayClusterUpdateRequest"></param>
	/// <param name="cancellationToken">Cancellation Token</param>
	/// <returns></returns>
	[ApiOperationId("updateCampusGatewayCluster")]
	[Put("/networks/{networkId}/campusGateway/clusters/{clusterId}")]
	public Task<NetworksCampusGatewayCluster> UpdateCampusGatewayClusterAsync(
		string networkId,
		string clusterId,
		[Body] NetworksCampusGatewayClusterUpdateRequest campusGatewayClusterUpdateRequest,
		CancellationToken cancellationToken = default
	);
}
