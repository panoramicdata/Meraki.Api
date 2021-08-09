using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMgDhcpSettings
	{
		/// <summary>
		/// getNetworkCellularGatewaySettingsDhcp
		/// </summary>
		/// <remarks>
		/// List common DHCP settings of MGs
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/cellularGateway/settings/dhcp")]
		Task<object> GetNetworkCellularGatewaySettingsDhcp(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// updateNetworkCellularGatewaySettingsDhcp
		/// </summary>
		/// <remarks>
		/// Update common DHCP settings of MGs
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkCellularGatewaySettingsDhcp"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/cellularGateway/settings/dhcp")]
		Task<object> UpdateNetworkCellularGatewaySettingsDhcp(
			[AliasAs("networkId")]string networkId,
			[Body]NetworkCellularGatewaySettingsDhcpUpdateRequest updateNetworkCellularGatewaySettingsDhcp
			);
	}
}
