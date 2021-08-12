using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMxVpnFirewallRules
	{
		/// <summary>
		/// Return the firewall rules for an organization&#39;s site-to-site VPN
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		[Get("/organizations/{organizationId}/appliance/vpn/vpnFirewallRules")]
		Task<VpnFirewallRulesUpdateRequest> GetOrganizationVpnFirewallRulesAsync(
			[AliasAs("organizationId")]string organizationId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the firewall rules of an organization&#39;s site-to-site VPN
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId">The organization id</param>
		/// <param name="UpdateOrganizationVpnFirewallRules">Body for updating firewall rules</param>
		[Put("/organizations/{organizationId}/appliance/vpn/vpnFirewallRules")]
		Task<VpnFirewallRulesUpdateRequest> UpdateOrganizationVpnFirewallRulesAsync(
			[AliasAs("organizationId")]string organizationId,
			[Body]VpnFirewallRulesUpdateRequest UpdateOrganizationVpnFirewallRules,
			CancellationToken cancellationToken = default
			);
	}
}
