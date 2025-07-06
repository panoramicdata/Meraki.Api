namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceFirewallOneToOneNatRules
{
	/// <summary>
	/// Return the 1:1 NAT mapping rules for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateNetworkApplianceFirewallOneToManyNatRules")]
	[Get("/networks/{networkId}/appliance/firewall/oneToOneNatRules")]
	Task<OneToOneNatRules> GetNetworkApplianceFirewallOneToOneNatRulesAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Set the 1:1 NAT mapping rules for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="oneToOneNatRules">Body for updating mapping rules</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateNetworkApplianceFirewallOneToOneNatRules")]
	[Put("/networks/{networkId}/appliance/firewall/oneToOneNatRules")]
	Task<OneToOneNatRules> UpdateNetworkApplianceFirewallOneToOneNatRulesAsync(
		string networkId,
		[Body] OneToOneNatRules oneToOneNatRules,
		CancellationToken cancellationToken = default
		);
}
