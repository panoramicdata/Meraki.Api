namespace Meraki.Api.Interfaces.Products.Wireless;

public interface IWirelessSsidsTrafficShaping
{
	/// <summary>
	/// Display the traffic shaping settings for a SSID on an MR network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="number">The SSID number</param>
	[Get("/networks/{networkId}/wireless/ssids/{number}/trafficShaping/rules")]
	Task<SsidTrafficShapingRules> GetNetworkWirelessSsidTrafficShapingRulesAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("number")] string number,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the traffic shaping settings for an SSID on an MR network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="number">The SSID number</param>
	/// <param name="updateNetworkSsidTrafficShaping"></param>
	[Put("/networks/{networkId}/wireless/ssids/{number}/trafficShaping/rules")]
	Task<SsidTrafficShapingRules> UpdateNetworkWirelessSsidTrafficShapingRulesAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("number")] string number,
		[Body] SsidTrafficShapingRules updateNetworkSsidTrafficShaping,
		CancellationToken cancellationToken = default
		);
}
