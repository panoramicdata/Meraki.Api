namespace Meraki.Api.Interfaces.Products.CellularGateway;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ICellularGatewayDhcp
{
	/// <summary>
	/// List common DHCP settings of MGs
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[Get("/networks/{networkId}/cellularGateway/dhcp")]
	Task<NetworkCellularGatewayDhcp> GetNetworkCellularGatewayDhcpAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update common DHCP settings of MGs
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="updateNetworkCellularGatewaySettingsDhcp">Body for updating DHCP settings</param>
	[Put("/networks/{networkId}/cellularGateway/dhcp")]
	Task<NetworkCellularGatewayDhcp> UpdateNetworkCellularGatewayDhcpAsync(
		string networkId,
		[Body] NetworkCellularGatewayDhcp updateNetworkCellularGatewaySettingsDhcp,
		CancellationToken cancellationToken = default
		);
}
