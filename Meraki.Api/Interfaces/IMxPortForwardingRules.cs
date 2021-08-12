using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMxPortForwardingRules
	{
		/// <summary>
		/// Return the port forwarding rules for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/portForwardingRules")]
		Task<PortForwardingRulesUpdateRequest> GetNetworkPortForwardingRulesAsync(
			[AliasAs("networkId")]string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the port forwarding rules for an MX network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="UpdateNetworkPortForwardingRules">Body for updating port forwarding rules</param>
		[Put("/networks/{networkId}/portForwardingRules")]
		Task<PortForwardingRulesUpdateRequest> UpdateNetworkPortForwardingRulesAsync(
			[AliasAs("networkId")]string networkId, 
			[Body]PortForwardingRulesUpdateRequest UpdateNetworkPortForwardingRules,
			CancellationToken cancellationToken = default
			);
	}
}
