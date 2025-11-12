namespace Meraki.Api.Interfaces.General.Networks;

/// <summary>
/// I Networks Clients Usage History
/// </summary>
public interface INetworksClientsUsageHistory
{
	/// <summary>
	/// Return the client's daily usage history
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="clientId">The client id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkClientUsageHistory")]
	[Get("/networks/{networkId}/clients/{clientId}/usageHistory")]
	Task<List<ClientUsageHistory>> GetNetworkClientUsageHistoryAsync(
		string networkId,
		string clientId,
		CancellationToken cancellationToken = default);
}
