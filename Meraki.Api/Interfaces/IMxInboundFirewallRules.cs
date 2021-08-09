using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMxInboundFirewallRules
	{
		/// <summary>
		/// getNetworkApplianceFirewallInboundFirewallRules
		/// </summary>
		/// <remarks>
		/// Return the inbound firewall rules for an MX network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/appliance/firewall/inboundFirewallRules")]
		Task<object> GetNetworkApplianceFirewallInboundFirewallRules(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// updateNetworkApplianceFirewallInboundFirewallRules
		/// </summary>
		/// <remarks>
		/// Update the inbound firewall rules of an MX network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkApplianceFirewallInboundFirewallRules"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/appliance/firewall/inboundFirewallRules")]
		Task<object> UpdateNetworkApplianceFirewallInboundFirewallRules(
			[AliasAs("networkId")]string networkId,
			[Body]NetworkApplianceFirewallInboundFirewallRulesUpdateRequest updateNetworkApplianceFirewallInboundFirewallRules
			);
	}
}
