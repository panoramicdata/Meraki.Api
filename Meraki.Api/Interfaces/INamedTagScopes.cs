using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface INamedTagScopes
	{
		/// <summary>
		/// Add a target group
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="CreateNetworkSmTargetGroup">Body for adding target group</param>
		[Post("/networks/{networkId}/sm/targetGroups")]
		Task<SmTargetGroupCreationRequest> CreateNetworkSmTargetGroupAsync(
			[AliasAs("networkId")] string networkId,
			[Body] SmTargetGroupCreationRequest CreateNetworkSmTargetGroup,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Delete a target group from a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="targetGroupId">The target group id</param>
		[Delete("/networks/{networkId}/sm/targetGroups/{targetGroupId}")]
		Task DeleteNetworkSmTargetGroupAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("targetGroupId")] string targetGroupId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return a target group
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="targetGroupId">The target group id</param>
		/// <param name="withDetails">Boolean indicating if the ids of the devices or users scoped by the target group should be included in the response (optional)</param>
		[Get("/networks/{networkId}/sm/targetGroups/{targetGroupId}")]
		Task<SmTargetGroupCreationRequest> GetNetworkSmTargetGroupAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("targetGroupId")] string targetGroupId,
			[AliasAs("withDetails")] bool? withDetails = null,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List the target groups in this network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="withDetails">Boolean indicating if the ids of the devices or users scoped by the target group should be included in the response (optional)</param>
		[Get("/networks/{networkId}/sm/targetGroups")]
		Task<List<SmTargetGroupCreationRequest>> GetNetworkSmTargetGroupsAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("withDetails")] bool? withDetails = null,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update a target group
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="targetGroupId">The target group id</param>
		/// <param name="UpdateNetworkSmTargetGroup">Body for updating a target group</param>
		[Put("/networks/{networkId}/sm/targetGroups/{targetGroupId}")]
		Task<SmTargetGroupCreationRequest> UpdateNetworkSmTargetGroupAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("targetGroupId")] string targetGroupId,
			[Body] SmTargetGroupUpdateRequest UpdateNetworkSmTargetGroup,
			CancellationToken cancellationToken = default
			);
	}
}
