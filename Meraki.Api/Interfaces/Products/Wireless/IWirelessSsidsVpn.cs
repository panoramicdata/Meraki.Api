namespace Meraki.Api.Interfaces.Products.Wireless;

public interface IWirelessSsidsVpn
{
	/// <summary>
	/// List the VPN settings for the SSID.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="number">The SSID number</param>
	[Get("/networks/{networkId}/wireless/ssids/{number}/vpn")]
	Task<VpnSettings> GetNetworkWirelessSsidVpnAsync(
		string networkId,
		string number,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the VPN settings for the SSID
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="number">The SSID number</param>
	/// <param name="updateNetworkWirelessSsidVpn"></param>
	[Put("/networks/{networkId}/wireless/ssids/{number}/vpn")]
	Task<VpnSettings> UpdateNetworkWirelessSsidVpnAsync(
		string networkId,
		string number,
		[Body] VpnSettings updateNetworkWirelessSsidVpn,
		CancellationToken cancellationToken = default
		);
}
