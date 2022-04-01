namespace Meraki.Api.Interfaces.Products.CellularGateway;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ICellularGatewaySubnetPool
{
	/// <summary>
	/// Return the subnet pool and mask configured for MGs in the network.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[Get("/networks/{networkId}/cellularGateway/subnetPool")]
	Task<NetworkCellularGatewaySubnetPool> GetNetworkCellularGatewaySubnetPoolAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the subnet pool and mask configuration for MGs in the network.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="updateNetworkCellularGatewaySettingsSubnetPool">Body for updating subnet pool and mask config</param>
	[Put("/networks/{networkId}/cellularGateway/subnetPool")]
	Task<NetworkCellularGatewaySubnetPool> UpdateNetworkCellularGatewaySubnetPoolAsync(
		[AliasAs("networkId")] string networkId,
		[Body] NetworkCellularGatewaySubnetPoolUpdateRequest updateNetworkCellularGatewaySettingsSubnetPool,
		CancellationToken cancellationToken = default
		);
}
