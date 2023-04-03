namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksHealthAlerts
{
	/// <summary>
	/// Return all global alerts on this network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkHealthAlerts")]
	[Get("/networks/{networkId}/health/alerts")]
	Task<List<HealthAlert>> GetNetworkHealthAlertsAsync(
		string networkId,
		CancellationToken cancellationToken = default);
}
