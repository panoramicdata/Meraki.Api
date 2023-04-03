namespace Meraki.Api.Interfaces.General.Networks;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface INetworksPiiRequests
{
	/// <summary>
	/// List the PII requests for this network or organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkPiiRequests")]
	[Get("/networks/{networkId}/pii/requests")]
	Task<List<PiiRequest>> GetNetworkPiiRequestsAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Submit a new delete or restrict processing PII request
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="piiRequest">Body for creating a PII request</param>
	[ApiOperationId("createNetworkPiiRequest")]
	[Post("/networks/{networkId}/pii/requests")]
	Task<PiiRequest> CreateNetworkPiiRequestAsync(
		string networkId,
		[Body] PiiRequestCreateRequest piiRequest,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return a PII request
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="requestId">The request id</param>
	[ApiOperationId("getNetworkPiiRequest")]
	[Get("/networks/{networkId}/pii/requests/{requestId}")]
	Task<PiiRequest> GetNetworkPiiRequestAsync(
		string networkId,
		string requestId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete a restrict processing PII request
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="requestId">The request id</param>
	[ApiOperationId("deleteNetworkPiiRequest")]
	[Delete("/networks/{networkId}/pii/requests/{requestId}")]
	Task DeleteNetworkPiiRequestAsync(
		string networkId,
		string requestId,
		CancellationToken cancellationToken = default
		);
}
