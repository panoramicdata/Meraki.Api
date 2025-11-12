namespace Meraki.Api.Interfaces.Products.Appliance;

/// <summary>
/// I Appliance Firewall L3Firewall Rules
/// </summary>
public interface IApplianceFirewallL3FirewallRules
{
	/// <summary>
	/// Return the L3 firewall rules for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/appliance/firewall/l3FirewallRules")]
	Task<Layer3FirewallRules> GetNetworkApplianceFirewallL3FirewallRulesAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the L3 firewall rules of an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="updateNetworkL3FirewallRules">Body for updating L3 firewall rules</param>
	/// <param name="cancellationToken"></param>
	[Put("/networks/{networkId}/appliance/firewall/l3FirewallRules")]
	Task<Layer3FirewallRules> UpdateNetworkApplianceFirewallL3FirewallRulesAsync(
		string networkId,
		[Body] Layer3FirewallRules updateNetworkL3FirewallRules,
		CancellationToken cancellationToken = default);
}
