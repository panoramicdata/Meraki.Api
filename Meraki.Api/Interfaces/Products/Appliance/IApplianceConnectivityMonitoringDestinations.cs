namespace Meraki.Api.Interfaces.Products.Appliance;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IApplianceConnectivityMonitoringDestinations
{
	/// <summary>
	/// Return the connectivity testing destinations for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[Get("/networks/{networkId}/appliance/connectivityMonitoringDestinations")]
	Task<NetworkConnectivityMonitoringDestinations> GetNetworkApplianceConnectivityMonitoringDestinationsAsync(
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
	Task<NetworkConnectivityMonitoringDestinations> UpdateNetworkApplianceConnectivityMonitoringDestinationsAsync(
		[AliasAs("networkId")] string networkId,
		[Body] NetworkConnectivityMonitoringDestinations updateNetworkConnectivityMonitoringDestinations,
		CancellationToken cancellationToken = default
		);
}
