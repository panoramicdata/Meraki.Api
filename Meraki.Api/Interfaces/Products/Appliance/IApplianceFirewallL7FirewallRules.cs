namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceFirewallL7FirewallRules
{
	/// <summary>
	/// List the MX L7 firewall rules for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkApplianceFirewallL7FirewallRules")]
	[Get("/networks/{networkId}/appliance/firewall/l7FirewallRules")]
	Task<Layer7FirewallRules> GetNetworkApplianceFirewallL7FirewallRulesAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the MX L7 firewall rules for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="layer7FirewallRules">Body for updating firewall rules</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateNetworkApplianceFirewallL7FirewallRules")]
	[Put("/networks/{networkId}/appliance/firewall/l7FirewallRules")]
	Task<Layer7FirewallRules> UpdateNetworkApplianceFirewallL7FirewallRulesAsync(
		string networkId,
		[Body] Layer7FirewallRules layer7FirewallRules,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return the L7 firewall application categories and their associated applications for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkApplianceFirewallL7FirewallRulesApplicationCategories")]
	[Get("/networks/{networkId}/appliance/firewall/l7FirewallRules/applicationCategories")]
	Task<Layer7ApplicationCategories> GetNetworkApplianceFirewallL7FirewallRulesApplicationCategoriesAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);
}
