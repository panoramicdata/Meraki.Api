using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMgConnectivityMonitoringDestinations
	{
		/// <summary>
		/// getNetworkCellularGatewaySettingsConnectivityMonitoringDestinations
		/// </summary>
		/// <remarks>
		/// Return the connectivity testing destinations for an MG network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/cellularGateway/settings/connectivityMonitoringDestinations")]
		Task<object> GetNetworkCellularGatewaySettingsConnectivityMonitoringDestinations(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// updateNetworkCellularGatewaySettingsConnectivityMonitoringDestinations
		/// </summary>
		/// <remarks>
		/// Update the connectivity testing destinations for an MG network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkCellularGatewaySettingsConnectivityMonitoringDestinations"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/cellularGateway/settings/connectivityMonitoringDestinations")]
		Task<object> UpdateNetworkCellularGatewaySettingsConnectivityMonitoringDestinations(
			[AliasAs("networkId")]string networkId,
			[Body]NetworkCellularGatewaySettingsConnectivityMonitoringDestinationsUpdateRequest updateNetworkCellularGatewaySettingsConnectivityMonitoringDestinations
			);
	}
}
