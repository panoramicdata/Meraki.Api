namespace Meraki.Api.Interfaces.General.Networks;
/// <summary>
/// I Networks Policies
/// </summary>
public interface INetworksPolicies
{

	/// <summary>
	/// Get policies for all clients with policies
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getNetworkPoliciesByClient")]
	[Get("/networks/{networkId}/policies/byClient")]
	Task<List<NetworkPolicyByClient>> GetNetworkPoliciesByClientAsync(
		string networkId,
		CancellationToken cancellationToken = default
	);
}
