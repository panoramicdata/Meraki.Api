namespace Meraki.Api.Interfaces.Products.Wireless;

/// <summary>
/// I Wireless Ssids Splash
/// </summary>
public interface IWirelessSsidsSplash
{
	/// <summary>
	/// Modify the splash page settings for the given SSID
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="number">The SSID number</param>
	/// <param name="updateNetworkWirelessSsidSplashSettings"></param>
	/// <param name="cancellationToken"></param>
	[Put("/networks/{networkId}/wireless/ssids/{number}/splash/settings")]
	Task<SsidSplashSettings> UpdateNetworkWirelessSsidSplashSettingsAsync(
		string networkId,
		string number,
		[Body] SsidSplashSettings updateNetworkWirelessSsidSplashSettings,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Display the splash page settings for the given SSID
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="number">The SSID number</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/wireless/ssids/{number}/splash/settings")]
	Task<SsidSplashSettings> GetNetworkWirelessSsidSplashSettingsAsync(
		string networkId,
		string number,
		CancellationToken cancellationToken = default
		);
}
