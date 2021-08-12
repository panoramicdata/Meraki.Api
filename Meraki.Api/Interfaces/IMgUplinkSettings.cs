using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMgUplinkSettings
	{
		/// <summary>
		/// getNetworkCellularGatewaySettingsUplink
		/// </summary>
		/// <remarks>
		/// Returns the uplink settings for your MG network.
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/cellularGateway/settings/uplink")]
		Task<object> GetNetworkCellularGatewaySettingsUplink(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// updateNetworkCellularGatewaySettingsUplink
		/// </summary>
		/// <remarks>
		/// Updates the uplink settings for your MG network.
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="updateNetworkCellularGatewaySettingsUplink"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/cellularGateway/settings/uplink")]
		Task<object> UpdateNetworkCellularGatewaySettingsUplink(
			[AliasAs("networkId")]string networkId,
			[Body]NetworkCellularGatewaySettingsUplinkUpdateRequest updateNetworkCellularGatewaySettingsUplink
			);
	}
}
