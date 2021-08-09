using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IMxPortForwardingRules
	{
		/// <summary>
		/// getNetworkPortForwardingRules
		/// </summary>
		/// <remarks>
		/// Return the port forwarding rules for an MX network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/portForwardingRules")]
		Task<object> GetNetworkPortForwardingRules([AliasAs("networkId")]string networkId);

		/// <summary>
		/// updateNetworkPortForwardingRules
		/// </summary>
		/// <remarks>
		/// Update the port forwarding rules for an MX network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkPortForwardingRules"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/portForwardingRules")]
		Task<object> UpdateNetworkPortForwardingRules([AliasAs("networkId")]string networkId, [Body]PortForwardingRulesUpdateRequest updateNetworkPortForwardingRules);
	}
}
