using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IConnectivityMonitoringDestinations
	{
		/// <summary>
		/// Return the connectivity testing destinations for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/appliance/connectivityMonitoringDestinations")]
		Task<NetworkConnectivityMonitoringDestinations> GetNetworkConnectivityMonitoringDestinationsAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the connectivity testing destinations for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="updateNetworkConnectivityMonitoringDestinations">Body for updating monitoring destinations</param>
		[Put("/networks/{networkId}/appliance/connectivityMonitoringDestinations")]
		Task<NetworkConnectivityMonitoringDestinations> UpdateNetworkConnectivityMonitoringDestinationsAsync(
			[AliasAs("networkId")] string networkId,
			[Body] NetworkConnectivityMonitoringDestinations updateNetworkConnectivityMonitoringDestinations,
			CancellationToken cancellationToken = default
			);
	}
}
