namespace Meraki.Api.Interfaces.Products.Sm;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ISmTargetGroups
{
	/// <summary>
	/// Add a target group
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="createNetworkSmTargetGroup">Body for adding target group</param>
	[Post("/networks/{networkId}/sm/targetGroups")]
	Task<SmTargetGroup> CreateNetworkSmTargetGroupAsync(
		string networkId,
		[Body] SmTargetGroupCreateUpdateRequest createNetworkSmTargetGroup,
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
		string networkId,
		string targetGroupId,
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
	Task<SmTargetGroup> GetNetworkSmTargetGroupAsync(
		string networkId,
		string targetGroupId,
		bool? withDetails = null,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// List the target groups in this network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="withDetails">Boolean indicating if the ids of the devices or users scoped by the target group should be included in the response (optional)</param>
	[Get("/networks/{networkId}/sm/targetGroups")]
	Task<List<SmTargetGroup>> GetNetworkSmTargetGroupsAsync(
		string networkId,
		bool? withDetails = null,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update a target group
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="targetGroupId">The target group id</param>
	/// <param name="updateNetworkSmTargetGroup">Body for updating a target group</param>
	[Put("/networks/{networkId}/sm/targetGroups/{targetGroupId}")]
	Task<SmTargetGroup> UpdateNetworkSmTargetGroupAsync(
		string networkId,
		string targetGroupId,
		[Body] SmTargetGroupCreateUpdateRequest updateNetworkSmTargetGroup,
		CancellationToken cancellationToken = default
		);
}
