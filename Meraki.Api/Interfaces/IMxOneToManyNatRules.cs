using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMxOneToManyNatRules
	{
		/// <summary>
		/// getNetworkOneToManyNatRules
		/// </summary>
		/// <remarks>
		/// Return the 1:Many NAT mapping rules for an MX network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/appliance/firewall/oneToManyNatRules")]
		Task<object> GetNetworkOneToManyNatRules(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// updateNetworkOneToManyNatRules
		/// </summary>
		/// <remarks>
		/// Set the 1:Many NAT mapping rules for an MX network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkOneToManyNatRules"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/appliance/firewall/oneToManyNatRules")]
		Task<object> UpdateNetworkOneToManyNatRules(
			[AliasAs("networkId")]string networkId,
			[Body]OneToManyNatRulesUpdateRequest updateNetworkOneToManyNatRules
			);
	}
}
