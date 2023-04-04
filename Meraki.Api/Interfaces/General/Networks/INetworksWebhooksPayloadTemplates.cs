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
	Task<List<PayloadTemplate>> GetNetworkWebhooksPayloadTemplatesAsync(
		string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Create a webhook payload template for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="webhookPayloadTemplate">Payload Template</param>
	[ApiOperationId("createNetworkWebhooksPayloadTemplate")]
	[Post("/networks/{networkId}/webhooks/payloadTemplates")]
	Task<PayloadTemplate> CreateNetworkWebhooksPayloadTemplateAsync(
		string networkId,
		[Body] PayloadTemplate webhookPayloadTemplate,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return a single network webhook payload template
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="payloadTemplateId">The payload template id</param>
	[ApiOperationId("getNetworkWebhooksPayloadTemplate")]
	[Get("/networks/{networkId}/webhooks/payloadTemplates/{payloadTemplateId}")]
	Task<PayloadTemplate> GetNetworkWebhooksPayloadTemplateAsync(
		string networkId,
		string payloadTemplateId,
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
		string networkId,
		string payloadTemplateId,
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
	Task<PayloadTemplate> UpdateNetworkWebhooksPayloadTemplateAsync(
		string networkId,
		string payloadTemplateId,
		[Body] PayloadTemplate webhookPayloadTemplate,
		CancellationToken cancellationToken = default);
}