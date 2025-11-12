namespace Meraki.Api.Interfaces.Products.Appliance;

/// <summary>
/// I Appliance Firewall Inbound Cellular Firewall Rules
/// </summary>
public interface IApplianceFirewallInboundCellularFirewallRules
{
	/// <summary>
	/// Return the inbound cellular firewall rules for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkApplianceFirewallInboundCellularFirewallRules")]
	[Get("/networks/{networkId}/appliance/firewall/inboundCellularFirewallRules")]
	Task<List<MxFirewallRule>> GetNetworkApplianceFirewallInboundCellularFirewallRulesAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the cellular firewall rules of an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="inboundCellularFirewallRules">Body for updating network inbound cellular firewall rules</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateNetworkApplianceFirewallInboundCellularFirewallRules")]
	[Put("/networks/{networkId}/appliance/firewall/inboundCellularFirewallRules")]
	Task<List<InboundCellularFirewallRules>> UpdateNetworkApplianceFirewallInboundCellularFirewallRulesAsync(
		string networkId,
		[Body] InboundCellularFirewallRules inboundCellularFirewallRules,
		CancellationToken cancellationToken = default
		);
}
