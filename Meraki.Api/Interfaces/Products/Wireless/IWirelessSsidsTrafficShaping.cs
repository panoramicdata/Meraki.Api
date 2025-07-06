namespace Meraki.Api.Interfaces.Products.Wireless;

public interface IWirelessSsidsTrafficShaping
{
	/// <summary>
	/// Display the traffic shaping rules for a SSID on an MR network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="number">The SSID number</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/wireless/ssids/{number}/trafficShaping/rules")]
	Task<SsidTrafficShapingRules> GetNetworkWirelessSsidTrafficShapingRulesAsync(
		string networkId,
		string number,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the traffic shaping rules for an SSID on an MR network.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="number">The SSID number</param>
	/// <param name="updateNetworkSsidTrafficShaping"></param>
	/// <param name="cancellationToken"></param>
	[Put("/networks/{networkId}/wireless/ssids/{number}/trafficShaping/rules")]
	Task<SsidTrafficShapingRules> UpdateNetworkWirelessSsidTrafficShapingRulesAsync(
		string networkId,
		string number,
		[Body] SsidTrafficShapingRules updateNetworkSsidTrafficShaping,
		CancellationToken cancellationToken = default
		);
}
