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
		/// List the access policies for a switch network.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/switch/accessPolicies")]
		Task<List<AccessPolicy>> GetNetworkAccessPoliciesAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Create an access policy for a switch network.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="CreateNetworkSwitchAccessPolicy">Body for creating network switch access policy</param>
		[Post("/networks/{networkId}/switch/accessPolicies")]
		Task<AccessPolicy> CreateNetworkSwitchAccessPolicyAsync(
			[AliasAs("networkId")] string networkId,
			[Body]AccessPolicy CreateNetworkSwitchAccessPolicy,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return a specific access policy for a switch network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="accessPolicyNumber">The access policy number</param>
		[Get("/networks/{networkId}/switch/accessPolicies/{accessPolicyNumber}")]
		Task<AccessPolicy> GetNetworkSwitchAccessPolicyAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("accessPolicyNumber")] string accessPolicyNumber,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Update an access policy for a switch network.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="accessPolicyNumber">The access policy number</param>
		/// <param name="UpdateNetworkSwitchAccessPolicy">Body for updating network switch access policy</param>
		[Put("/networks/{networkId}/switch/accessPolicies/{accessPolicyNumber}")]
		Task<AccessPolicy> UpdateNetworkSwitchAccessPolicyAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("accessPolicyNumber")] string accessPolicyNumber,
			[Body]AccessPolicy UpdateNetworkSwitchAccessPolicy,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Delete an access policy for a switch network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="accessPolicyNumber">The access policy number</param>
		[Delete("/networks/{networkId}/switch/accessPolicies/{accessPolicyNumber}")]
		Task DeleteNetworkSwitchAccessPolicyAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("accessPolicyNumber")] string accessPolicyNumber,
			CancellationToken cancellationToken = default);
	}
}
