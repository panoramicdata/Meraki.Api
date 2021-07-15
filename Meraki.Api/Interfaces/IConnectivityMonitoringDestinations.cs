using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IConnectivityMonitoringDestinations
	{
		/// <summary>
		/// getNetworkConnectivityMonitoringDestinations
		/// </summary>
		/// <remarks>
		/// Return the connectivity testing destinations for an MX network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/appliance/connectivityMonitoringDestinations")]
		Task<object> GetNetworkConnectivityMonitoringDestinations(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// updateNetworkConnectivityMonitoringDestinations
		/// </summary>
		/// <remarks>
		/// Update the connectivity testing destinations for an MX network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkConnectivityMonitoringDestinations"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/appliance/connectivityMonitoringDestinations")]
		Task<object> UpdateNetworkConnectivityMonitoringDestinations(
			[AliasAs("networkId")]string networkId,
			[Body]NetworkConnectivityMonitoringDestinations updateNetworkConnectivityMonitoringDestinations
			);
	}
}
