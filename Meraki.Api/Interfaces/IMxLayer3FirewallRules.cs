using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMxLayer3FirewallRules
	{
		/// <summary>
		/// getNetworkL3FirewallRules
		/// </summary>
		/// <remarks>
		/// Return the L3 firewall rules for an MX network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/l3FirewallRules")]
		Task<object> GetNetworkL3FirewallRules(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// updateNetworkL3FirewallRules
		/// </summary>
		/// <remarks>
		/// Update the L3 firewall rules of an MX network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkL3FirewallRules"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/l3FirewallRules")]
		Task<object> UpdateNetworkL3FirewallRules(
			[AliasAs("networkId")]string networkId,
			[Body]Layer3FirewallRulesUpdateRequest updateNetworkL3FirewallRules);
	}
}
