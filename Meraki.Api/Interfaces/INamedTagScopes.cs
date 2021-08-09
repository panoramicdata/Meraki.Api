using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface INamedTagScopes
	{
		/// <summary>
		/// createNetworkSmTargetGroup
		/// </summary>
		/// <remarks>
		/// Add a target group
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="createNetworkSmTargetGroup"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/sm/targetGroups")]
		Task<object> CreateNetworkSmTargetGroup(
			[AliasAs("networkId")]string networkId,
			[Body]SmTargetGroupCreationRequest createNetworkSmTargetGroup
			);

		/// <summary>
		/// deleteNetworkSmTargetGroup
		/// </summary>
		/// <remarks>
		/// Delete a target group from a network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="targetGroupId"></param>
		/// <returns>Task of void</returns>
		[Delete("/networks/{networkId}/sm/targetGroups/{targetGroupId}")]
		Task DeleteNetworkSmTargetGroup(
			[AliasAs("networkId")]string networkId,
			[AliasAs("targetGroupId")]string targetGroupId
			);

		/// <summary>
		/// getNetworkSmTargetGroup
		/// </summary>
		/// <remarks>
		/// Return a target group
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="targetGroupId"></param>
		/// <param name="withDetails">Boolean indicating if the ids of the devices or users scoped by the target group should be included in the response (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/sm/targetGroups/{targetGroupId}")]
		Task<object> GetNetworkSmTargetGroup(
			[AliasAs("networkId")]string networkId,
			[AliasAs("targetGroupId")]string targetGroupId,
			[AliasAs("withDetails")]bool? withDetails = null
			);

		/// <summary>
		/// getNetworkSmTargetGroups
		/// </summary>
		/// <remarks>
		/// List the target groups in this network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="withDetails">Boolean indicating if the ids of the devices or users scoped by the target group should be included in the response (optional)</param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/sm/targetGroups")]
		Task<object> GetNetworkSmTargetGroups(
			[AliasAs("networkId")]string networkId,
			[AliasAs("withDetails")]bool? withDetails = null
			);

		/// <summary>
		/// updateNetworkSmTargetGroup
		/// </summary>
		/// <remarks>
		/// Update a target group
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="targetGroupId"></param>
		/// <param name="updateNetworkSmTargetGroup"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/sm/targetGroups/{targetGroupId}")]
		Task<object> UpdateNetworkSmTargetGroup(
			[AliasAs("networkId")]string networkId,
			[AliasAs("targetGroupId")]string targetGroupId,
			[Body]SmTargetGroupUpdateRequest updateNetworkSmTargetGroup
			);
	}
}
