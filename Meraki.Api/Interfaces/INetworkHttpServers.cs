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
	public interface INetworkHttpServers
	{
		/// <summary>
		/// Return an HTTP server for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="httpServerId">The id of a HTTP server</param>
		[Get("/networks/{networkId}/webhooks/httpServers/{httpServerId}")]
		Task<WebhookHttpServer> GetAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("httpServerId")] string httpServerId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// List the HTTP servers for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/webhooks/httpServers")]
		Task<List<WebhookHttpServer>> GetAllAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Add an HTTP server to a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="httpServer">Body for creating a network HTTP server</param>
		[Post("/networks/{networkId}/webhooks/httpServers")]
		Task<WebhookHttpServer> CreateAsync(
			[AliasAs("networkId")] string networkId,
			[Body] WebhookHttpServer httpServer,
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
		Task<WebhookHttpServer> UpdateAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("httpServerId")] string httpServerId,
			[Body] WebhookHttpServer httpServer,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Delete an HTTP server from a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="httpServerId">The id of a HTTP server</param>
		[Delete("/networks/{networkId}/webhooks/httpServers/{httpServerId}")]
		Task DeleteAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("httpServerId")] string httpServerId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Return the status of a webhook test for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="webhookTestId">The id of a webhook test</param>
		[Get("/networks/{networkId}/webhooks/webhookTests/{webhookTestId}")]
		Task<WebhookTest> GetWebhookTestAsync(
			[AliasAs("networkId")] string networkId,
			[AliasAs("webhookTestId")] string webhookTestId,
			CancellationToken cancellationToken = default
			);

		/// <summary>
		/// Send a test webhook for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="webhookTest">Body for creating a network HTTP server webhook test</param>
		[Post("/networks/{networkId}/webhooks/webhookTests")]
		Task<WebhookTest> CreateWebhookTestAsync(
			[AliasAs("networkId")] string networkId,
			[Body] WebhookTest webhookTest,
			CancellationToken cancellationToken = default
			);
	}
}
