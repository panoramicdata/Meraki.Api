namespace Meraki.Api.Interfaces.General.Networks;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface INetworksWebhooksPayloadTemplates
{
	/// <summary>
	/// Return the list of network webhook payload templates
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[Get("/networks/{networkId}/webhooks/payloadTemplates")]
	Task<List<PayloadTemplate>> GetNetworksWebhooksPayloadTemplatesAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return the list of network webhook payload templates
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[Post("/networks/{networkId}/webhooks/payloadTemplates")]
	Task UpdateNetworksWebhooksPayloadTemplatesAsync(
		[AliasAs("networkId")] string networkId,
		[Body] List<PayloadTemplate> webhookPayloadTemplates,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return a single network webhook payload template
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="payloadTemplateId">The payload template id</param>
	[Get("/networks/{networkId}/webhooks/payloadTemplates/{payloadTemplateId}")]
	Task<PayloadTemplate> GetNetworksWebhooksPayloadTemplateAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("payloadTemplateId")] string payloadTemplateId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Delete a single network webhook payload template
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="payloadTemplateId">The payload template id</param>
	[Delete("/networks/{networkId}/webhooks/payloadTemplates/{payloadTemplateId}")]
	Task DeleteNetworksWebhooksPayloadTemplateAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("payloadTemplateId")] string payloadTemplateId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update a single network webhook payload template
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="payloadTemplateId">The payload template id</param>
	[Put("/networks/{networkId}/webhooks/payloadTemplates/{payloadTemplateId}")]
	Task UpdateNetworksWebhooksPayloadTemplateAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("payloadTemplateId")] string payloadTemplateId,
		[Body] PayloadTemplate webhookPayloadTemplate,
		CancellationToken cancellationToken = default);
}