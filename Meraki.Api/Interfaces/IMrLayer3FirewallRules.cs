using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMrLayer3FirewallRules
	{
		/// <summary>
		/// getNetworkSsidL3FirewallRules
		/// </summary>
		/// <remarks>
		/// Return the L3 firewall rules for an SSID on an MR network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/ssids/{number}/l3FirewallRules")]
		Task<object> GetNetworkSsidL3FirewallRules(
			[AliasAs("networkId")]string networkId,
			[AliasAs("number")]string number
			);

		/// <summary>
		/// updateNetworkSsidL3FirewallRules
		/// </summary>
		/// <remarks>
		/// Update the L3 firewall rules of an SSID on an MR network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="number"></param>
		/// <param name="updateNetworkSsidL3FirewallRules"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/ssids/{number}/l3FirewallRules")]
		Task<object> UpdateNetworkSsidL3FirewallRules(
			[AliasAs("networkId")]string networkId,
			[AliasAs("number")]string number,
			[Body]SsidLayer3FirewallRulesUpdateRequest updateNetworkSsidL3FirewallRules
			);
	}
}
