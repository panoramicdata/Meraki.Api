using Meraki.Api.Data;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IAccessPolicies
	{
		/// <summary>
		/// getNetworkSwitchAccessPolicies
		/// </summary>
		/// <remarks>
		/// List the access policies for a switch network. Only returns access policies with 'my RADIUS server' as authentication method
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/switch/accessPolicies")]
		Task<List<AccessPolicy>> GetNetworkAccessPolicies(
			[AliasAs("networkId")] string networkId
			);

		/// <summary>
		/// createNetworkSwitchAccessPolicy
		/// </summary>
		/// <remarks>
		/// Create an access policy for a switch network. This endpoint only supports access policies with 'My RADIUS server' as authentication method.
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="createNetworkSwitchAccessPolicy"></param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/switch/accessPolicies")]
		Task<AccessPolicy> CreateNetworkSwitchAccessPolicy(
			[AliasAs("networkId")] string networkId,
			[Body]AccessPolicy createNetworkSwitchAccessPolicy
			);

		/// <summary>
		/// getNetworkSwitchAccessPolicy
		/// </summary>
		/// <remarks>
		/// Return a specific access policy for a switch network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="accessPolicyNumber"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/switch/accessPolicies/{accessPolicyNumber}")]
		Task<AccessPolicy> GetNetworkSwitchAccessPolicy(
			[AliasAs("networkId")] string networkId,
			[AliasAs("accessPolicyNumber")] string accessPolicyNumber
			);

		/// <summary>
		/// updateNetworkSwitchAccessPolicy
		/// </summary>
		/// <remarks>
		/// Update an access policy for a switch network. This endpoint only supports access policies with 'My RADIUS server' as authentication method.
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="accessPolicyNumber"></param>
		/// <param name="updateNetworkSwitchAccessPolicy"></param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/switch/accessPolicies/{accessPolicyNumber}")]
		Task<AccessPolicy> UpdateNetworkSwitchAccessPolicy(
			[AliasAs("networkId")] string networkId,
			[AliasAs("accessPolicyNumber")] string accessPolicyNumber,
			[Body]AccessPolicy updateNetworkSwitchAccessPolicy
			);

		/// <summary>
		/// deleteNetworkSwitchAccessPolicy
		/// </summary>
		/// <remarks>
		/// Delete an access policy for a switch network
		/// </remarks>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="accessPolicyNumber"></param>
		/// <returns>Task of void</returns>
		[Delete("/networks/{networkId}/switch/accessPolicies/{accessPolicyNumber}")]
		Task DeleteNetworkSwitchAccessPolicy(
			[AliasAs("networkId")] string networkId,
			[AliasAs("accessPolicyNumber")] string accessPolicyNumber,
			CancellationToken cancellationToken = default);
	}
}
