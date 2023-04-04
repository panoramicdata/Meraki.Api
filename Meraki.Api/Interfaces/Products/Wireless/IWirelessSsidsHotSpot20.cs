namespace Meraki.Api.Interfaces.Products.Wireless;

public interface IWirelessSsidsHotSpot20
{
	/// <summary>
	/// Return the Hotspot 2.0 settings for an SSID
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="number">The SSID number</param>
	[Get("/networks/{networkId}/wireless/ssids/{number}/hotspot20")]
	Task<Hotspot20> GetNetworkWirelessSsidHotspot20Async(
		string networkId,
		string number,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the Hotspot 2.0 settings of an SSID
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="number">The SSID number</param>
	/// <param name="hotspot20"></param>
	[Put("/networks/{networkId}/wireless/ssids/{number}/hotspot20")]
	Task<Hotspot20> UpdateNetworkWirelessSsidHotspot20Async(
		string networkId,
		string number,
		[Body] Hotspot20 hotspot20,
		CancellationToken cancellationToken = default
		);
}
