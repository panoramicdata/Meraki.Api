using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMxLayer7ApplicationCategories
	{
		/// <summary>
		/// getNetworkL7FirewallRulesApplicationCategories
		/// </summary>
		/// <remarks>
		/// Return the L7 firewall application categories and their associated applications for an MX network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/l7FirewallRules/applicationCategories")]
		Task<object> GetNetworkL7FirewallRulesApplicationCategories(
			[AliasAs("networkId")]string networkId
			);
	}
}
