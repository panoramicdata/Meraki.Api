namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksGroupPolicies
{
	/// <summary>
	/// List the group policies in a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkGroupPolicies")]
	[Get("/networks/{networkId}/groupPolicies")]
	Task<List<GroupPolicy>> GetNetworkGroupPoliciesAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Create a group policy
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="createNetworkGroupPolicy">Body for creating a network group policy</param>
	[ApiOperationId("createNetworkGroupPolicy")]
	[Post("/networks/{networkId}/groupPolicies")]
	Task<GroupPolicy> CreateNetworkGroupPolicyAsync(
		[AliasAs("networkId")] string networkId,
		[Body] GroupPolicy createNetworkGroupPolicy,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Display a group policy
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="groupPolicyId">The group policy id</param>
	[ApiOperationId("getNetworkGroupPolicy")]
	[Get("/networks/{networkId}/groupPolicies/{groupPolicyId}")]
	Task<GroupPolicy> GetNetworkGroupPolicyAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("groupPolicyId")] string groupPolicyId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update a group policy
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="groupPolicyId"></param>
	/// <param name="updateNetworkGroupPolicy">Body for updating a network group policy</param>
	[ApiOperationId("updateNetworkGroupPolicy")]
	[Put("/networks/{networkId}/groupPolicies/{groupPolicyId}")]
	Task<GroupPolicy> UpdateNetworkGroupPolicyAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("groupPolicyId")] string groupPolicyId,
		[Body] GroupPolicy updateNetworkGroupPolicy,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Delete a group policy
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="groupPolicyId">The group policy id</param>
	[ApiOperationId("deleteNetworkGroupPolicy")]
	[Delete("/networks/{networkId}/groupPolicies/{groupPolicyId}")]
	Task DeleteNetworkGroupPolicyAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("groupPolicyId")] string groupPolicyId,
		CancellationToken cancellationToken = default
		);
}
