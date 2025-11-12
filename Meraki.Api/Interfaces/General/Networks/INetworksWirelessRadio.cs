namespace Meraki.Api.Interfaces.General.Networks;
/// <summary>
/// I Networks Wireless Radio
/// </summary>
public interface INetworksWirelessRadio
{
	/// <summary>
	/// Update the AutoRF settings for a wireless network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("updateNetworkWirelessRadioAutoRf")]
	[Put("/networks/{networkId}/wireless/radio/autoRf")]
	Task<NetworkWirelessRadioAutoRfUpdateResponse> UpdateNetworkWirelessRadioAutoRfAsync(
		string networkId,
		[Body] NetworkWirelessRadioAutoRfUpdateRequest request,
		CancellationToken cancellationToken = default
	);
}
