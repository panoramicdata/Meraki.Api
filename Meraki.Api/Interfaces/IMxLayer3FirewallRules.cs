using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMxLayer3FirewallRules
	{
		/// <summary>
		/// Return the L3 firewall rules for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/appliance/firewall/l3FirewallRules")]
		Task<Layer3FirewallRulesUpdateRequest> GetNetworkL3FirewallRulesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the L3 firewall rules of an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="UpdateNetworkL3FirewallRules">Body for updating L3 firewall rules</param>
		[Put("/networks/{networkId}/appliance/firewall/l3FirewallRules")]
		Task<Layer3FirewallRulesUpdateRequest> UpdateNetworkL3FirewallRulesAsync(
			[AliasAs("networkId")] string networkId,
			[Body] Layer3FirewallRulesUpdateRequest UpdateNetworkL3FirewallRules,
			CancellationToken cancellationToken = default);
	}
}
