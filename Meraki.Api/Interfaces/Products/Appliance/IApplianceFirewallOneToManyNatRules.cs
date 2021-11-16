namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceFirewallOneToManyNatRules
{
	/// <summary>
	/// Return the 1:Many NAT mapping rules for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkApplianceFirewallOneToManyNatRules")]
	[Get("/networks/{networkId}/appliance/firewall/oneToManyNatRules")]
	Task<OneToManyNatRules> GetNetworkApplianceFirewallOneToManyNatRulesAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Set the 1:Many NAT mapping rules for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="oneToManyNatRules">Body for updating mapping rules</param>
	[ApiOperationId("updateNetworkApplianceFirewallOneToManyNatRules")]
	[Put("/networks/{networkId}/appliance/firewall/oneToManyNatRules")]
	Task<OneToManyNatRules> UpdateNetworkApplianceFirewallOneToManyNatRulesAsync(
		[AliasAs("networkId")] string networkId,
		[Body] OneToManyNatRules oneToManyNatRules,
		CancellationToken cancellationToken = default
		);
}
