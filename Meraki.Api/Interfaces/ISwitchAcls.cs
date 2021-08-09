using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ISwitchAcls
	{
		/// <summary>
		/// getNetworkSwitchAccessControlLists
		/// </summary>
		/// <remarks>
		/// Return the access control lists for a MS network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/switch/accessControlLists")]
		Task<object> GetNetworkSwitchAccessControlLists(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// updateNetworkSwitchAccessControlLists
		/// </summary>
		/// <remarks>
		/// Update the access control lists for a MS network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkSwitchAccessControlLists"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/switch/accessControlLists")]
		Task<object> UpdateNetworkSwitchAccessControlLists(
			[AliasAs("networkId")]string networkId,
			[Body]SwitchAccessControlListRulesUpdateRequest updateNetworkSwitchAccessControlLists
			);
	}
}
