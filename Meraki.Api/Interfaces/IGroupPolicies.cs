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
	public interface IGroupPolicies
	{
		/// <summary>
		/// Create a group policy
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="createNetworkGroupPolicy">Body for creating a network group policy</param>
		[Post("/networks/{networkId}/groupPolicies")]
		Task<GroupPolicyCreationRequest> CreateNetworkGroupPolicyAsync(
			[AliasAs("networkId")] string networkId,
			[Body] GroupPolicyCreationRequest createNetworkGroupPolicy,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Delete a group policy
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="groupPolicyId">The group policy id</param>
		[Delete("/networks/{networkId}/groupPolicies/{groupPolicyId}")]
		Task DeleteNetworkGroupPolicyAsync(
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
		Task<List<GroupPolicyCreationRequest>> GetNetworkGroupPoliciesAsync(
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
		Task<GroupPolicyCreationRequest> GetNetworkGroupPolicyAsync(
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
		Task<GroupPolicyUpdateRequest> UpdateNetworkGroupPolicyAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("groupPolicyId")] string groupPolicyId,
			[Body] GroupPolicyUpdateRequest updateNetworkGroupPolicy,
			CancellationToken cancellationToken = default);
	}
}
