using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMxLayer7ApplicationCategories
	{
		/// <summary>
		/// Return the L7 firewall application categories and their associated applications for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/l7FirewallRules/applicationCategories")]
		Task<L7ApplicationCategories> GetNetworkL7FirewallRulesApplicationCategoriesAsync(
			[AliasAs("networkId")]string networkId,
			CancellationToken cancellationToken = default
			);
	}
}
