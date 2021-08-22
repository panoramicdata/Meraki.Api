using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMgDhcpSettings
	{
		/// <summary>
		/// List common DHCP settings of MGs
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/cellularGateway/dhcp")]
		Task<NetworkCellularGatewaySettingsDhcpUpdateRequest> GetNetworkCellularGatewaySettingsDhcpAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update common DHCP settings of MGs
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="updateNetworkCellularGatewaySettingsDhcp">Body for updating DHCP settings</param>
		[Put("/networks/{networkId}/cellularGateway/dhcp")]
		Task<NetworkCellularGatewaySettingsDhcpUpdateRequest> UpdateNetworkCellularGatewaySettingsDhcpAsync(
			[AliasAs("networkId")] string networkId,
			[Body] NetworkCellularGatewaySettingsDhcpUpdateRequest updateNetworkCellularGatewaySettingsDhcp,
			CancellationToken cancellationToken = default
			);
	}
}
