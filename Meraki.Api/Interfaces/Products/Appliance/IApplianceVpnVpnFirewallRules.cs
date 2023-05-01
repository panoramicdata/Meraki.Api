namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceVpnVpnFirewallRules
{
	/// <summary>
	/// Return the firewall rules for an organization's site-to-site VPN
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[ApiOperationId("getOrganizationApplianceVpnVpnFirewallRules")]
	[Get("/organizations/{organizationId}/appliance/vpn/vpnFirewallRules")]
	Task<VpnFirewallRules> GetOrganizationApplianceVpnVpnFirewallRulesAsync(
		string organizationId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the firewall rules of an organization's site-to-site VPN
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="vpnFirewallRules">Body for updating firewall rules</param>
	[ApiOperationId("updateOrganizationApplianceVpnVpnFirewallRules")]
	[Put("/organizations/{organizationId}/appliance/vpn/vpnFirewallRules")]
	Task<VpnFirewallRules> UpdateOrganizationApplianceVpnVpnFirewallRulesAsync(
		string organizationId,
		[Body] VpnFirewallRules vpnFirewallRules,
		CancellationToken cancellationToken = default
		);
}
