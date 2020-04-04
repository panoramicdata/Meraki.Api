using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMxVpnFirewallRules
	{
		/// <summary>
		/// getOrganizationVpnFirewallRules
		/// </summary>
		/// <remarks>
		/// Return the firewall rules for an organization&#39;s site-to-site VPN
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <returns>Task of Object</returns>
		[Get("/organizations/{organizationId}/vpnFirewallRules")]
		Task<object> GetOrganizationVpnFirewallRules(
			[AliasAs("organizationId")]string organizationId
			);

		/// <summary>
		/// updateOrganizationVpnFirewallRules
		/// </summary>
		/// <remarks>
		/// Update the firewall rules of an organization&#39;s site-to-site VPN
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="organizationId"></param>
		/// <param name="updateOrganizationVpnFirewallRules"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/organizations/{organizationId}/vpnFirewallRules")]
		Task<object> UpdateOrganizationVpnFirewallRules(
			[AliasAs("organizationId")]string organizationId,
			[Body]UpdateOrganizationVpnFirewallRules updateOrganizationVpnFirewallRules
			);
	}
}
