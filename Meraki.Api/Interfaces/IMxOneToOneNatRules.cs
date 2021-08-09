using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMxOneToOneNatRules
	{
		/// <summary>
		/// getNetworkOneToOneNatRules
		/// </summary>
		/// <remarks>
		/// Return the 1:1 NAT mapping rules for an MX network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/appliance/firewall/oneToOneNatRules")]
		Task<object> GetNetworkOneToOneNatRules(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// updateNetworkOneToOneNatRules
		/// </summary>
		/// <remarks>
		/// Set the 1:1 NAT mapping rules for an MX network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkOneToOneNatRules"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/appliance/firewall/oneToOneNatRules")]
		Task<object> UpdateNetworkOneToOneNatRules(
			[AliasAs("networkId")]string networkId,
			[Body]OneToOneNatRulesUpdateRequest updateNetworkOneToOneNatRules
			);
	}
}
