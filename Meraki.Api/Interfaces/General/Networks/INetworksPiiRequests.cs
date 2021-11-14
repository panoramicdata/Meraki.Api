namespace Meraki.Api.Interfaces.General.Networks;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface INetworksPiiRequests
{
	/// <summary>
	/// Return a PII request
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="requestId">The request id</param>
	[Get("/networks/{networkId}/pii/requests/{requestId}")]
	Task<PiiRequest> GetAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("requestId")] string requestId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// List the PII requests for this network or organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[Get("/networks/{networkId}/pii/requests")]
	Task<List<PiiRequest>> GetAllAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Submit a new delete or restrict processing PII request
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="piiRequest">Body for creating a PII request</param>
	[Post("/networks/{networkId}/pii/requests")]
	Task<PiiRequest> CreateAsync(
		[AliasAs("networkId")] string networkId,
		[Body] PiiRequestCreateRequest piiRequest,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete a restrict processing PII request
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="requestId">The request id</param>
	[Delete("/networks/{networkId}/pii/requests/{requestId}")]
	Task DeleteAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("requestId")] string requestId,
		CancellationToken cancellationToken = default
		);
}
