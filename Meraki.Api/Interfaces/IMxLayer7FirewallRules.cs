using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMxLayer7FirewallRules
	{
		/// <summary>
		/// List the MX L7 firewall rules for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/l7FirewallRules")]
		Task<Layer7FirewallRulesUpdateRequest> GetNetworkL7FirewallRulesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the MX L7 firewall rules for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="updateNetworkL7FirewallRules">Body for updating firewall rules</param>
		[Put("/networks/{networkId}/l7FirewallRules")]
		Task<Layer7FirewallRulesUpdateRequest> UpdateNetworkL7FirewallRulesAsync(
			[AliasAs("networkId")] string networkId,
			[Body] Layer7FirewallRulesUpdateRequest updateNetworkL7FirewallRules,
			CancellationToken cancellationToken = default
			);
	}
}
