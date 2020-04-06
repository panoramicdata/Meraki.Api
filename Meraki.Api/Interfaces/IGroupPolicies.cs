using Meraki.Api.Data;
using Refit;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IGroupPolicies
	{
		/// <summary>
		/// createNetworkGroupPolicy
		/// </summary>
		/// <remarks>
		/// Create a group policy
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="createNetworkGroupPolicy"></param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/groupPolicies")]
		Task<object> CreateNetworkGroupPolicy(
			[AliasAs("networkId")]string networkId,
			[Body]GroupPolicyCreationRequest createNetworkGroupPolicy
			);

		/// <summary>
		/// deleteNetworkGroupPolicy
		/// </summary>
		/// <remarks>
		/// Delete a group policy
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="groupPolicyId"></param>
		/// <returns>Task of void</returns>
		[Delete("/networks/{networkId}/groupPolicies/{groupPolicyId}")]
		Task DeleteNetworkGroupPolicy(
			[AliasAs("networkId")]string networkId,
			[AliasAs("groupPolicyId")]string groupPolicyId
			);

		/// <summary>
		/// getNetworkGroupPolicies
		/// </summary>
		/// <remarks>
		/// List the group policies in a network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/groupPolicies")]
		Task<object> GetNetworkGroupPolicies(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// getNetworkGroupPolicy
		/// </summary>
		/// <remarks>
		/// Display a group policy
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="groupPolicyId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/groupPolicies/{groupPolicyId}")]
		Task<object> GetNetworkGroupPolicy(
			[AliasAs("networkId")]string networkId,
			[AliasAs("groupPolicyId")]string groupPolicyId
			);

		/// <summary>
		/// updateNetworkGroupPolicy
		/// </summary>
		/// <remarks>
		/// Update a group policy
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="groupPolicyId"></param>
		/// <param name="updateNetworkGroupPolicy"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/groupPolicies/{groupPolicyId}")]
		Task<object> UpdateNetworkGroupPolicy(
			[AliasAs("networkId")]string networkId,
			[AliasAs("groupPolicyId")]string groupPolicyId,
			[Body]GroupPolicyUpdateRequest updateNetworkGroupPolicy);
	}
}
