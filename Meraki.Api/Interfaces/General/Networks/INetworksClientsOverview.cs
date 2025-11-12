namespace Meraki.Api.Interfaces.General.Networks;

/// <summary>
/// I Networks Clients Overview
/// </summary>
public interface INetworksClientsOverview
{
	/// <summary>
	/// Return overview statistics for network clients
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkClientsOverview")]
	[Get("/networks/{networkId}/clients/overview")]
	Task<NetworkClientOverview> GetNetworkClientsOverviewAsync(
		string networkId,
		CancellationToken cancellationToken = default);
}
