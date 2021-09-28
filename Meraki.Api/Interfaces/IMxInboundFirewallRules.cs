using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Inbound firewall rules for an MX network
	/// </summary>
	public interface IMxInboundFirewallRules
	{
		/// <summary>
		/// Return the inbound firewall rules for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/appliance/firewall/inboundFirewallRules")]
		Task<NetworkApplianceInboundFirewallRules> GetNetworkApplianceInboundFirewallRulesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the inbound firewall rules of an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="networkApplianceInboundFirewallRules">Body for updating inbound firewall rules</param>
		[Put("/networks/{networkId}/appliance/firewall/inboundFirewallRules")]
		Task<NetworkApplianceInboundFirewallRules> UpdateNetworkApplianceInboundFirewallRulesAsync(
			[AliasAs("networkId")] string networkId,
			[Body] NetworkApplianceInboundFirewallRules networkApplianceInboundFirewallRules,
			CancellationToken cancellationToken = default
			);
	}
}
