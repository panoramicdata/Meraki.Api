namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceFirewallCellularFirewallRules
{
	/// <summary>
	/// Return the cellular firewall rules for an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/appliance/firewall/cellularFirewallRules")]
	Task<CellularFirewallRules> GetNetworkApplianceFirewallCellularFirewallRulesAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the cellular firewall rules of an MX network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="mxCellularFirewallRules">Body for updating network cellular firewall rules</param>
	/// <param name="cancellationToken"></param>
	[Put("/networks/{networkId}/appliance/firewall/cellularFirewallRules")]
	Task<CellularFirewallRules> UpdateNetworkApplianceFirewallCellularFirewallRulesAsync(
		string networkId,
		[Body] CellularFirewallRules mxCellularFirewallRules,
		CancellationToken cancellationToken = default
		);
}
