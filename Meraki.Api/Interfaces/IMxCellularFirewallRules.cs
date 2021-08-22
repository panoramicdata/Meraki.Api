using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMxCellularFirewallRules
	{
		/// <summary>
		/// Return the cellular firewall rules for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/cellularFirewallRules")]
		Task<MxCellularFirewallRulesUpdateRequest> GetAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the cellular firewall rules of an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="updateNetworkCellularFirewallRules">Body for updating network cellular firewall rules</param>
		[Put("/networks/{networkId}/cellularFirewallRules")]
		Task<MxCellularFirewallRulesUpdateRequest> UpdateAsync(
			[AliasAs("networkId")] string networkId,
			[Body] MxCellularFirewallRulesUpdateRequest updateNetworkCellularFirewallRules,
			CancellationToken cancellationToken = default
			);
	}
}
