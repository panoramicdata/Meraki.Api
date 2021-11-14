namespace Meraki.Api.Interfaces.Products.Wireless;

public interface IWirelessSsidsFirewall
{
	/// <summary>
	/// Return the L7 firewall rules for an SSID on an MR network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="number">The SSID number</param>
	[Get("/networks/{networkId}/wireless/ssids/{number}/firewall/l7FirewallRules")]
	Task<SsidL7FirewallRules> GetNetworkWirelessSsidFirewallL7FirewallRulesAsync(
	[AliasAs("networkId")] string networkId,
	[AliasAs("number")] string number,
	CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return the L7 firewall rules for an SSID on an MR network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="number">The SSID number</param>
	/// <param name="updateNetworkWirelessSsidFirewallL7FirewallRules">Body for updating L7 Firewall rules</param>
	[Put("/networks/{networkId}/wireless/ssids/{number}/firewall/l7FirewallRules")]
	Task<SsidL7FirewallRules> UpdateNetworkWirelessSsidFirewallL7FirewallRulesAsync(
	[AliasAs("networkId")] string networkId,
	[AliasAs("number")] string number,
	[Body] SsidL7FirewallRules updateNetworkWirelessSsidFirewallL7FirewallRules,
	CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return the L3 firewall rules for an SSID on an MR network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="number">The SSID number</param>
	[Get("/networks/{networkId}/ssids/{number}/l3FirewallRules")]
	Task<SsidLayer3FirewallRulesUpdateRequest> GetNetworkSsidL3FirewallRulesAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("number")] string number,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the L3 firewall rules of an SSID on an MR network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="number">The SSID number</param>
	/// <param name="updateNetworkSsidL3FirewallRules">Body for updating L3 firewall rules</param>
	[Put("/networks/{networkId}/ssids/{number}/l3FirewallRules")]
	Task<SsidLayer3FirewallRulesUpdateRequest> UpdateNetworkSsidL3FirewallRulesAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("number")] string number,
		[Body] SsidLayer3FirewallRulesUpdateRequest updateNetworkSsidL3FirewallRules,
		CancellationToken cancellationToken = default
		);
}
