using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMgSubnetPoolSettings
	{
		/// <summary>
		/// Return the subnet pool and mask configured for MGs in the network.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/cellularGateway/settings/subnetPool")]
		Task<NetworkCellularGatewaySettingsSubnetPool> GetNetworkCellularGatewaySettingsSubnetPoolAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the subnet pool and mask configuration for MGs in the network.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="UpdateNetworkCellularGatewaySettingsSubnetPool">Body for updating subnet pool and mask config</param>
		[Put("/networks/{networkId}/cellularGateway/settings/subnetPool")]
		Task<NetworkCellularGatewaySettingsSubnetPool> UpdateNetworkCellularGatewaySettingsSubnetPoolAsync(
			[AliasAs("networkId")] string networkId,
			[Body] NetworkCellularGatewaySettingsSubnetPoolUpdateRequest UpdateNetworkCellularGatewaySettingsSubnetPool,
			CancellationToken cancellationToken = default
			);
	}
}
