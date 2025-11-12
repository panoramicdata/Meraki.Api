namespace Meraki.Api.Interfaces.General.Networks;

/// <summary>
/// I Networks Health Alerts
/// </summary>
public interface INetworksHealthAlerts
{
	/// <summary>
	/// Return all global alerts on this network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkHealthAlerts")]
	[Get("/networks/{networkId}/health/alerts")]
	Task<List<HealthAlert>> GetNetworkHealthAlertsAsync(
		string networkId,
		CancellationToken cancellationToken = default);
}
