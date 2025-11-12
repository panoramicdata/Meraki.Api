namespace Meraki.Api.Interfaces.General.Networks;

/// <summary>
/// I Networks Wireless Zigbee
/// </summary>
public interface INetworksWirelessZigbee
{
	/// <summary>
	/// Update Zigbee Configs for specified network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateNetworkWirelessZigbee")]
	[Put("/networks/{networkId}/wireless/zigbee")]
	Task<NetworkWirelessZigbeeUpdateResponse> UpdateNetworkWirelessZigbeeAsync(
		string networkId,
		[Body] NetworkWirelessZigbeeUpdateRequest request,
		CancellationToken cancellationToken = default
	);
}
