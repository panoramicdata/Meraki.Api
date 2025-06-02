namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksWirelessClients
{
	/// <summary>
	/// Fetch the health scores for all clients on this network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getNetworkWirelessClientsHealthScores")]
	[Get("/networks/{networkId}/wireless/clients/healthScores")]
	Task<List<WirelessClientHealthScore>> GetNetworkWirelessClientsHealthScoresAsync(
		string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return counts of distinct wireless clients connecting to a network over time
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getNetworkWirelessClientsOnboardingHistory")]
	[Get("/networks/{networkId}/wireless/clients/onboardingHistory")]
	Task<List<WirelessClientOnboardingHistory>> GetNetworkWirelessClientsOnboardingHistoryAsync(
		string networkId,
		CancellationToken cancellationToken = default);
}
