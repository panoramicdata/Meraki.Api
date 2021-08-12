using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMrLayer3FirewallRules
	{
		/// <summary>
		/// Return the L3 firewall rules for an SSID on an MR network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="number">The SSID number</param>
		[Get("/networks/{networkId}/ssids/{number}/l3FirewallRules")]
		Task<SsidLayer3FirewallRulesUpdateRequest> GetNetworkSsidL3FirewallRulesAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("number")]string number,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the L3 firewall rules of an SSID on an MR network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="number">The SSID number</param>
		/// <param name="UpdateNetworkSsidL3FirewallRules">Body for updating L3 firewall rules</param>
		[Put("/networks/{networkId}/ssids/{number}/l3FirewallRules")]
		Task<SsidLayer3FirewallRulesUpdateRequest> UpdateNetworkSsidL3FirewallRulesAsync(
			[AliasAs("networkId")]string networkId,
			[AliasAs("number")]string number,
			[Body]SsidLayer3FirewallRulesUpdateRequest UpdateNetworkSsidL3FirewallRules,
			CancellationToken cancellationToken = default
			);
	}
}
