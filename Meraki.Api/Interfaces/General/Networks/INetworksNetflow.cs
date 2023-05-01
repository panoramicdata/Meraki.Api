namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksNetflow
{
	/// <summary>
	/// Return the NetFlow traffic reporting settings for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkNetflow")]
	[Get("/networks/{networkId}/netflow")]
	Task<Netflow> GetNetworkNetflowAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the NetFlow traffic reporting settings for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="netflow">Body for updating netflow traffic</param>
	[ApiOperationId("updateNetworkNetflow")]
	[Put("/networks/{networkId}/netflow")]
	Task<Netflow> UpdateNetworkNetflowAsync(
		string networkId,
		[Body] Netflow netflow,
		CancellationToken cancellationToken = default
		);
}
