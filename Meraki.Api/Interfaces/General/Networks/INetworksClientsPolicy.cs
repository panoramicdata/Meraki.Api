namespace Meraki.Api.Interfaces.General.Networks;

/// <summary>
/// I Networks Clients Policy
/// </summary>
public interface INetworksClientsPolicy
{
	/// <summary>
	/// Return the policy assigned to a client on the network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="clientId">The client id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkClientPolicy")]
	[Get("/networks/{networkId}/clients/{clientId}/policy")]
	Task<ClientPolicyUpdateRequest> GetNetworkClientPolicyAsync(
		string networkId,
		string clientId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update the policy assigned to a client on the network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="clientId">The client id</param>
	/// <param name="clientPolicyUpdateRequest">Body for updating client policy</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateNetworkClientPolicy")]
	[Put("/networks/{networkId}/clients/{clientId}/policy")]
	Task<ClientPolicyUpdateRequest> UpdateNetworkClientPolicyAsync(
		string networkId,
		string clientId,
		[Body] ClientPolicyUpdateRequest clientPolicyUpdateRequest,
		CancellationToken cancellationToken = default);
}
