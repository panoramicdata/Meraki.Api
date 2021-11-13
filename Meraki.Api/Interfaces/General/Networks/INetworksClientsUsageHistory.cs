namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksClientsUsageHistory
{
	/// <summary>
	/// Return the client's daily usage history
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="clientId">The client id</param>
	[Get("/networks/{networkId}/clients/{clientId}/usageHistory")]
	Task<List<ClientUsageHistory>> GetNetworkClientUsageHistoryAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("clientId")] string clientId,
		CancellationToken cancellationToken = default);
}
