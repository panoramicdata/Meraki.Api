namespace Meraki.Api.Interfaces.Products.CellularGateway;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ICellularGatewayUplink
{
	/// <summary>
	/// Returns the uplink settings for your MG network.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[Get("/networks/{networkId}/cellularGateway/uplink")]
	Task<NetworkCellularGatewayUplink> GetNetworkCellularGatewaySettingsUplinkAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Updates the uplink settings for your MG network.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="updateNetworkCellularGatewaySettingsUplink">Body for updating uplink settings</param>
	[Put("/networks/{networkId}/cellularGateway/uplink")]
	Task<NetworkCellularGatewayUplink> UpdateNetworkCellularGatewaySettingsUplinkAsync(
		[AliasAs("networkId")] string networkId,
		[Body] NetworkCellularGatewayUplink updateNetworkCellularGatewaySettingsUplink,
		CancellationToken cancellationToken = default
		);
}
