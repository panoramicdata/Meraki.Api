namespace Meraki.Api.Interfaces.Products.Switch;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ISwitchAccessPolicies
{
	/// <summary>
	/// List the access policies for a switch network.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkSwitchAccessPolicies")]
	[Get("/networks/{networkId}/switch/accessPolicies")]
	Task<List<AccessPolicy>> GetNetworkSwitchAccessPoliciesAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Create an access policy for a switch network.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="createNetworkSwitchAccessPolicy">Body for creating network switch access policy</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("createNetworkSwitchAccessPolicy")]
	[Post("/networks/{networkId}/switch/accessPolicies")]
	Task<AccessPolicy> CreateNetworkSwitchAccessPolicyAsync(
		string networkId,
		[Body] AccessPolicy createNetworkSwitchAccessPolicy,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return a specific access policy for a switch network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="accessPolicyNumber">The access policy number</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkSwitchAccessPolicy")]
	[Get("/networks/{networkId}/switch/accessPolicies/{accessPolicyNumber}")]
	Task<AccessPolicy> GetNetworkSwitchAccessPolicyAsync(
		string networkId,
		string accessPolicyNumber,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update an access policy for a switch network.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="accessPolicyNumber">The access policy number</param>
	/// <param name="updateNetworkSwitchAccessPolicy">Body for updating network switch access policy</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateNetworkSwitchAccessPolicy")]
	[Put("/networks/{networkId}/switch/accessPolicies/{accessPolicyNumber}")]
	Task<AccessPolicy> UpdateNetworkSwitchAccessPolicyAsync(
		string networkId,
		string accessPolicyNumber,
		[Body] AccessPolicy updateNetworkSwitchAccessPolicy,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete an access policy for a switch network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="accessPolicyNumber">The access policy number</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("deleteNetworkSwitchAccessPolicy")]
	[Delete("/networks/{networkId}/switch/accessPolicies/{accessPolicyNumber}")]
	Task DeleteNetworkSwitchAccessPolicyAsync(
		string networkId,
		string accessPolicyNumber,
		CancellationToken cancellationToken = default);
}
