namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksWebhooksHttpServers

{
	/// <summary>
	/// Return an HTTP server for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="httpServerId">The id of a HTTP server</param>
	[Get("/networks/{networkId}/webhooks/httpServers/{httpServerId}")]
	Task<WebHookHttpServer> GetNetworkWebhooksHttpServerAsync(
		string networkId,
		string httpServerId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// List the HTTP servers for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[Get("/networks/{networkId}/webhooks/httpServers")]
	Task<List<WebHookHttpServer>> GetNetworkWebhooksHttpServersAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Add an HTTP server to a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="httpServer">Body for creating a network HTTP server</param>
	[Post("/networks/{networkId}/webhooks/httpServers")]
	Task<WebHookHttpServer> CreateNetworkWebhooksHttpServerAsync(
		string networkId,
		[Body] WebHookHttpServer httpServer,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update an HTTP server
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="httpServerId">The id of a HTTP server</param>
	/// <param name="httpServer">Body for updating a network HTTP server</param>
	[Put("/networks/{networkId}/webhooks/httpServers/{httpServerId}")]
	Task<WebHookHttpServer> UpdateNetworkWebhooksHttpServerAsync(
		string networkId,
		string httpServerId,
		[Body] WebHookHttpServer httpServer,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete an HTTP server from a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="httpServerId">The id of a HTTP server</param>
	[Delete("/networks/{networkId}/webhooks/httpServers/{httpServerId}")]
	Task DeleteNetworkWebhooksHttpServerAsync(
		string networkId,
		string httpServerId,
		CancellationToken cancellationToken = default
		);
}
