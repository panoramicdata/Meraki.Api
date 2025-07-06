namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsWebhooksHttpServers

{
	/// <summary>
	/// Return an HTTP server for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="id">The id of a HTTP server</param>
	/// <param name="cancellationToken"></param>
	[Get("/organizations/{organizationId}/webhooks/httpServers/{id}")]
	Task<WebhookHttpServer> GetOrganizationWebhooksHttpServerAsync(
		string organizationId,
		string id,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// List the HTTP servers for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="cancellationToken"></param>
	[Get("/organizations/{organizationId}/webhooks/httpServers")]
	Task<List<WebhookHttpServer>> GetOrganizationWebhooksHttpServersAsync(
		string organizationId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Add an HTTP server to an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="httpServer">Body for creating an organization HTTP server</param>
	/// <param name="cancellationToken"></param>
	[Post("/organizations/{organizationId}/webhooks/httpServers")]
	Task<WebhookHttpServer> CreateOrganizationWebhooksHttpServerAsync(
		string organizationId,
		[Body] WebhookHttpServer httpServer,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update an HTTP server
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="id">The id of a HTTP server</param>
	/// <param name="httpServer">Body for updating an organization HTTP server</param>
	/// <param name="cancellationToken"></param>
	[Put("/organizations/{organizationId}/webhooks/httpServers/{id}")]
	Task<WebhookHttpServer> UpdateOrganizationWebhooksHttpServerAsync(
		string organizationId,
		string id,
		[Body] WebhookHttpServer httpServer,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Delete an HTTP server from an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="id">The id of a HTTP server</param>
	/// <param name="cancellationToken"></param>
	[Delete("/organizations/{organizationId}/webhooks/httpServers/{id}")]
	Task DeleteOrganizationWebhooksHttpServerAsync(
		string organizationId,
		string id,
		CancellationToken cancellationToken = default
		);
}
