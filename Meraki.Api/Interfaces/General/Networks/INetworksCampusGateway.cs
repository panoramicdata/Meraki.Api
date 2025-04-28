namespace Meraki.Api.Interfaces.General.Networks;
public interface INetworksCampusGateway
{
	/// <summary>
	/// Create a cluster and add campus gateways to it
	/// </summary>
	/// <param name="networkId">The Network ID</param>
	/// <param name="campusGatewayCluster">Campus Gateway Cluster Request</param>
	/// <param name="cancellationToken">Cancellation Token</param>
	/// <returns></returns>
	[Post("/networks/{networkId}/campusGateway/clusters")]
	public Task<NetworksCampusGatewayClusterResponse> CreateCampusGatewayClusterAsync(
		string networkId,
		[Body] NetworksCampusGatewayClusterRequest campusGatewayCluster,
		CancellationToken cancellationToken = default
	);
}
