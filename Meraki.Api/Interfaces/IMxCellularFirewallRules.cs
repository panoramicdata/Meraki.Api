using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMxCellularFirewallRules
	{
		/// <summary>
		/// getNetworkCellularFirewallRules
		/// </summary>
		/// <remarks>
		/// Return the cellular firewall rules for an MX network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/cellularFirewallRules")]
		Task<MxCellularFirewallRulesUpdateRequest> GetAsync(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// updateNetworkCellularFirewallRules
		/// </summary>
		/// <remarks>
		/// Update the cellular firewall rules of an MX network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="updateNetworkCellularFirewallRules"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/cellularFirewallRules")]
		Task<object> UpdateAsync(
			[AliasAs("networkId")]string networkId,
			[Body]MxCellularFirewallRulesUpdateRequest updateNetworkCellularFirewallRules
			);
	}
}
