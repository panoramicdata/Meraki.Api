using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMxLayer7FirewallRules
	{
		/// <summary>
		/// getNetworkL7FirewallRules
		/// </summary>
		/// <remarks>
		/// List the MX L7 firewall rules for an MX network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/l7FirewallRules")]
		Task<object> GetNetworkL7FirewallRules(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// updateNetworkL7FirewallRules
		/// </summary>
		/// <remarks>
		/// Update the MX L7 firewall rules for an MX network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkL7FirewallRules"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/l7FirewallRules")]
		Task<object> UpdateNetworkL7FirewallRules(
			[AliasAs("networkId")]string networkId,
			[Body]Layer7FirewallRulesUpdateRequest updateNetworkL7FirewallRules
			);
	}
}
