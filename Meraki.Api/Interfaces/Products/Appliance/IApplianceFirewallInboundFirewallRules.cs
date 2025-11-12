namespace Meraki.Api.Interfaces.Products.Appliance;

/// <summary>
/// I Appliance Firewall Inbound Firewall Rules
/// </summary>
public interface IApplianceFirewallInboundFirewallRules
{
	/// <summary>
	/// Return the inbound firewall rules for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/appliance/firewall/inboundFirewallRules")]
	Task<InboundFirewallRules> GetNetworkApplianceFirewallInboundFirewallRulesAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the inbound firewall rules of an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="inboundFirewallRules">Body for updating inbound firewall rules</param>
	/// <param name="cancellationToken"></param>
	[Put("/networks/{networkId}/appliance/firewall/inboundFirewallRules")]
	Task<InboundFirewallRules> UpdateNetworkApplianceFirewallInboundFirewallRulesAsync(
		string networkId,
		[Body] InboundFirewallRules inboundFirewallRules,
		CancellationToken cancellationToken = default
		);
}
