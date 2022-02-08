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
	[ApiOperationId("getNetworkWebhooksPayloadTemplates")]
	[Get("/networks/{networkId}/webhooks/payloadTemplates")]
	Task<List<PayloadTemplate>> GetNetworksWebhooksPayloadTemplatesAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Create a webhook payload template for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="createWebhookPayloadTemplate">Body</param>
	[ApiOperationId("createNetworkWebhooksPayloadTemplate")]
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
	[ApiOperationId("getNetworkWebhooksPayloadTemplate")]
	[Get("/networks/{networkId}/webhooks/payloadTemplates/{payloadTemplateId}")]
	Task<PayloadTemplate> GetNetworksWebhooksPayloadTemplateAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("payloadTemplateId")] string payloadTemplateId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Destroy a webhook payload template for a network. Does not work for included templates ('wpt_00001', 'wpt_00002', 'wpt_00003' or 'wpt_00004')
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="payloadTemplateId">The payload template id</param>
	[ApiOperationId("deleteNetworkWebhooksPayloadTemplate")]
	[Delete("/networks/{networkId}/webhooks/payloadTemplates/{payloadTemplateId}")]
	Task DeleteNetworkWebhooksPayloadTemplateAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("payloadTemplateId")] string payloadTemplateId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update a webhook payload template for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="payloadTemplateId">The payload template id</param>
	[ApiOperationId("updateNetworkWebhooksPayloadTemplate")]
	[Put("/networks/{networkId}/webhooks/payloadTemplates/{payloadTemplateId}")]
	Task<WebhookPayloadTemplates> UpdateNetworkWebhooksPayloadTemplateAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("payloadTemplateId")] string payloadTemplateId,
		[Body] PayloadTemplate webhookPayloadTemplate,
		CancellationToken cancellationToken = default);
}