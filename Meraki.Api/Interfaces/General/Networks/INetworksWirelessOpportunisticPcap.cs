namespace Meraki.Api.Interfaces.General.Networks;
/// <summary>
/// I Networks Wireless Opportunistic Pcap
/// </summary>
public interface INetworksWirelessOpportunisticPcap
{
	/// <summary>
	/// Update the Opportunistic Pcap settings for a wireless network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("updateNetworkWirelessOpportunisticPcap")]
	[Put("/networks/{networkId}/wireless/opportunisticPcap")]
	Task<NetworkOpportunisticPcap> UpdateNetworkWirelessOpportunisticPcapAsync(
		string networkId,
		[Body] NetworkOpportunisticPcapUpdateRequest request,
		CancellationToken cancellationToken = default
	);
}
