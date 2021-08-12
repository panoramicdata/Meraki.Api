using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMxOneToManyNatRules
	{
		/// <summary>
		/// Return the 1:Many NAT mapping rules for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/appliance/firewall/oneToManyNatRules")]
		Task<OneToManyNatRulesUpdateRequest> GetNetworkOneToManyNatRulesAsync(
			[AliasAs("networkId")]string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Set the 1:Many NAT mapping rules for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="UpdateNetworkOneToManyNatRules">Body for updating mapping rules</param>
		[Put("/networks/{networkId}/appliance/firewall/oneToManyNatRules")]
		Task<OneToManyNatRulesUpdateRequest> UpdateNetworkOneToManyNatRulesAsync(
			[AliasAs("networkId")]string networkId,
			[Body]OneToManyNatRulesUpdateRequest UpdateNetworkOneToManyNatRules,
			CancellationToken cancellationToken = default
			);
	}
}
