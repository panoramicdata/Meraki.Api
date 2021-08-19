using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMxOneToOneNatRules
	{
		/// <summary>
		/// Return the 1:1 NAT mapping rules for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/appliance/firewall/oneToOneNatRules")]
		Task<OneToOneNatRulesUpdateRequest> GetNetworkOneToOneNatRulesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Set the 1:1 NAT mapping rules for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="updateNetworkOneToOneNatRules">Body for updating mapping rules</param>
		[Put("/networks/{networkId}/appliance/firewall/oneToOneNatRules")]
		Task<OneToOneNatRulesUpdateRequest> UpdateNetworkOneToOneNatRulesAsync(
			[AliasAs("networkId")] string networkId,
			[Body] OneToOneNatRulesUpdateRequest updateNetworkOneToOneNatRules,
			CancellationToken cancellationToken = default
			);
	}
}
