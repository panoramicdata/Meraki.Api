namespace Meraki.Api.Interfaces.Products.Wireless;

public interface IWirelessSsids
{
	/// <summary>
	/// List the MR SSIDs in a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[Get("/networks/{networkId}/wireless/ssids")]
	Task<List<Ssid>> GetNetworkWirelessSsidsAsync(
		string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return a single MR SSID
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="number">The SSID number</param>
	[Get("/networks/{networkId}/wireless/ssids/{number}")]
	Task<Ssid> GetNetworkWirelessSsidAsync(
		string networkId,
		string number,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update the attributes of an MR SSID
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="number">The SSID number</param>
	/// <param name="updateNetworkSsid"></param>
	[Put("/networks/{networkId}/wireless/ssids/{number}")]
	Task<Ssid> UpdateNetworkWirelessSsidAsync(
		string networkId,
		string number,
		[Body] SsidUpdateRequest updateNetworkSsid,
		CancellationToken cancellationToken = default);
}
