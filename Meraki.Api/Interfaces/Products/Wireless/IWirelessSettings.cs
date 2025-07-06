namespace Meraki.Api.Interfaces.Products.Wireless;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IWirelessSettings
{
	/// <summary>
	/// Return the wireless settings for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/wireless/settings")]
	Task<WirelessSettings> GetNetworkWirelessSettingsAsync(
		string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update the wireless settings for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="updateNetworkWirelessSettings"></param>
	/// <param name="cancellationToken"></param>
	[Put("/networks/{networkId}/wireless/settings")]
	Task<WirelessSettings> UpdateNetworkWirelessSettingsAsync(
		string networkId,
		[Body] WirelessSettingsUpdateDto updateNetworkWirelessSettings,
		CancellationToken cancellationToken = default);
}
