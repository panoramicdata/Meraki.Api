namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksTopologyLinkLayer
{
	/// <summary>
	/// List of devices and connections among them within the network.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[Get("/networks/{networkId}/topology/linkLayer")]
	Task<LinkLayers> GetNetworkTopologyLinkLayerAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);
}
