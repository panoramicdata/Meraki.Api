namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceFirewallPortForwardingRules
{
	/// <summary>
	/// Return the port forwarding rules for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkApplianceFirewallPortForwardingRules")]
	[Get("/networks/{networkId}/appliance/firewall/portForwardingRules")]
	Task<PortForwardingRules> GetNetworkApplianceFirewallPortForwardingRulesAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the port forwarding rules for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="updateNetworkPortForwardingRules">Body for updating port forwarding rules</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateNetworkApplianceFirewallPortForwardingRules")]
	[Put("/networks/{networkId}/appliance/firewall/portForwardingRules")]
	Task<PortForwardingRules> UpdateNetworkApplianceFirewallPortForwardingRulesAsync(
		string networkId,
		[Body] PortForwardingRules updateNetworkPortForwardingRules,
		CancellationToken cancellationToken = default
		);
}
