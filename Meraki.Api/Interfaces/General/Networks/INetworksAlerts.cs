namespace Meraki.Api.Interfaces.General.Networks;
public interface INetworksAlerts
{
	/// <summary>
	/// Return the alert history for this network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getNetworkAlertsHistory")]
	[Get("/networks/{networkId}/alerts/history")]
	Task<List<NetworkAlertsHistoryItem>> GetNetworkAlertsHistoryAsync(
		string networkId,
		CancellationToken cancellationToken = default
	);
}
