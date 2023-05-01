namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksClientsOverview
{
	/// <summary>
	/// Return overview statistics for network clients
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkClientsOverview")]
	[Get("/networks/{networkId}/clients/overview")]
	Task<NetworkClientOverview> GetNetworkClientsOverviewAsync(
		string networkId,
		CancellationToken cancellationToken = default);
}
