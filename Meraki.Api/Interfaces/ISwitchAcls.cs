using Meraki.Api.Attributes;
using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface ISwitchAcls
	{
		/// <summary>
		/// Return the access control lists for a MS network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[ApiOperationId("getNetworkSwitchAccessControlLists")]
		[Get("/networks/{networkId}/switch/accessControlLists")]
		Task<SwitchAccessControlListRules> GetAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update the access control lists for a MS network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="updateNetworkSwitchAccessControlLists"></param>
		[ApiOperationId("updateNetworkSwitchAccessControlLists")]
		[Put("/networks/{networkId}/switch/accessControlLists")]
		Task<SwitchAccessControlListRules> UpdateAsync(
			[AliasAs("networkId")] string networkId,
			[Body] SwitchAccessControlListRules updateNetworkSwitchAccessControlLists,
			CancellationToken cancellationToken = default
			);
	}
}
