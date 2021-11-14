namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksGroupPolicies
{
	/// <summary>
	/// Create a group policy
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="createNetworkGroupPolicy">Body for creating a network group policy</param>
	[Post("/networks/{networkId}/groupPolicies")]
	Task<GroupPolicy> CreateAsync(
		[AliasAs("networkId")] string networkId,
		[Body] GroupPolicy createNetworkGroupPolicy,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete a group policy
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="groupPolicyId">The group policy id</param>
	[Delete("/networks/{networkId}/groupPolicies/{groupPolicyId}")]
	Task DeleteAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("groupPolicyId")] string groupPolicyId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// List the group policies in a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[Get("/networks/{networkId}/groupPolicies")]
	Task<List<GroupPolicy>> GetAllAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Display a group policy
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="groupPolicyId">The group policy id</param>
	[Get("/networks/{networkId}/groupPolicies/{groupPolicyId}")]
	Task<GroupPolicy> GetAsync(
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
	[Put("/networks/{networkId}/groupPolicies/{groupPolicyId}")]
	Task<GroupPolicy> UpdateAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("groupPolicyId")] string groupPolicyId,
		[Body] GroupPolicy updateNetworkGroupPolicy,
		CancellationToken cancellationToken = default);
}
