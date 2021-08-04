using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IHttpServers
	{
		/// <summary>
		/// createNetworkHttpServer
		/// </summary>
		/// <remarks>
		/// Add an HTTP server to a network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="createNetworkHttpServer"></param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/httpServers")]
		Task<object> CreateNetworkHttpServer(
			[AliasAs("networkId")]string networkId,
			[Body]HttpServerCreationRequest createNetworkHttpServer
			);

		/// <summary>
		/// createNetworkHttpServersWebhookTest
		/// </summary>
		/// <remarks>
		/// Send a test webhook for a network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="createNetworkHttpServersWebhookTest"></param>
		/// <returns>Task of Object</returns>
		[Post("/networks/{networkId}/httpServers/webhookTests")]
		Task<object> CreateNetworkHttpServersWebhookTest(
			[AliasAs("networkId")]string networkId,
			[Body]HttpServersWebhookTestCreationRequest createNetworkHttpServersWebhookTest
			);

		/// <summary>
		/// deleteNetworkHttpServer
		/// </summary>
		/// <remarks>
		/// Delete an HTTP server from a network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="id"></param>
		/// <returns>Task of void</returns>
		[Delete("/networks/{networkId}/httpServers/{id}")]
		Task DeleteNetworkHttpServer(
			[AliasAs("networkId")]string networkId,
			[AliasAs("id")]string id
			);

		/// <summary>
		/// getNetworkHttpServer
		/// </summary>
		/// <remarks>
		/// Return an HTTP server for a network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="id"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/httpServers/{id}")]
		Task<object> GetNetworkHttpServer(
			[AliasAs("networkId")]string networkId,
			[AliasAs("id")]string id
			);

		/// <summary>
		/// getNetworkWebhooksHttpServers
		/// </summary>
		/// <remarks>
		/// List the HTTP servers for a network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/webhooks/httpServers")]
		Task<List<HttpServers>> GetNetworkWebhooksHttpServers(
			[AliasAs("networkId")]string networkId
			);

		/// <summary>
		/// getNetworkHttpServersWebhookTest
		/// </summary>
		/// <remarks>
		/// Return the status of a webhook test for a network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="id"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/httpServers/webhookTests/{id}")]
		Task<object> GetNetworkHttpServersWebhookTest(
			[AliasAs("networkId")]string networkId,
			[AliasAs("id")]string id
			);

		/// <summary>
		/// updateNetworkHttpServer
		/// </summary>
		/// <remarks>
		/// Update an HTTP server
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="id"></param>
		/// <param name="updateNetworkHttpServer"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/httpServers/{id}")]
		Task<object> UpdateNetworkHttpServer(
			[AliasAs("networkId")]string networkId,
			[AliasAs("id")]string id,
			[Body]HttpServerUpdateRequest updateNetworkHttpServer
			);
	}
}
