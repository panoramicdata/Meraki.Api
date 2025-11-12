namespace Meraki.Api.Interfaces.Products.Appliance;

/// <summary>
/// I Appliance Firewall One To Many Nat Rules
/// </summary>
public interface IApplianceFirewallOneToManyNatRules
{
	/// <summary>
	/// Return the 1:Many NAT mapping rules for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkApplianceFirewallOneToManyNatRules")]
	[Get("/networks/{networkId}/appliance/firewall/oneToManyNatRules")]
	Task<OneToManyNatRules> GetNetworkApplianceFirewallOneToManyNatRulesAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Set the 1:Many NAT mapping rules for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="oneToManyNatRules">Body for updating mapping rules</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateNetworkApplianceFirewallOneToManyNatRules")]
	[Put("/networks/{networkId}/appliance/firewall/oneToManyNatRules")]
	Task<OneToManyNatRules> UpdateNetworkApplianceFirewallOneToManyNatRulesAsync(
		string networkId,
		[Body] OneToManyNatRules oneToManyNatRules,
		CancellationToken cancellationToken = default
		);
}
