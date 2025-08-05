namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IOrganizationsWebhooksPayloadTemplates
{
	/// <summary>
	/// List the webhook payload templates for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="cancellationToken"></param>
	[Get("/organizations/{organizationId}/webhooks/payloadTemplates")]
	Task<List<PayloadTemplate>> GetOrganizationWebhooksPayloadTemplatesAsync(
		string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// List the webhook payload templates for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="payloadTemplate">The Payload Template</param>
	/// <param name="cancellationToken"></param>
	[Post("/organizations/{organizationId}/webhooks/payloadTemplates")]
	Task<PayloadTemplate> CreateOrganizationWebhooksPayloadTemplatesAsync(
		string organizationId,
		PayloadTemplate payloadTemplate,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Get the webhook payload template for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="payloadTemplateId">The payload template id</param>
	/// <param name="cancellationToken"></param>
	[Get("/organizations/{organizationId}/webhooks/payloadTemplates/{payloadTemplateId}")]
	Task<List<PayloadTemplate>> GetOrganizationWebhooksPayloadTemplateAsync(
		string organizationId,
		string payloadTemplateId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update a payload template for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="payloadTemplateId">The payload template id</param>
	/// <param name="webhookPayloadTemplate"></param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateOrganizationWebhooksPayloadTemplate")]
	[Put("/organizations/{organizationId}/webhooks/payloadTemplates/{payloadTemplateId}")]
	Task<PayloadTemplate> UpdateOrganizationWebhooksPayloadTemplateAsync(
		string organizationId,
		string payloadTemplateId,
		[Body] PayloadTemplate webhookPayloadTemplate,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Destroy a webhook payload template for an organization. Does not work for included templates ('wpt_00001', 'wpt_00002', 'wpt_00003', 'wpt_00004', 'wpt_00005' or 'wpt_00006')
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="payloadTemplateId"></param>
	/// <param name="cancellationToken"></param>
	[Delete("/organizations/{organizationId}/webhooks/payloadTemplates/{payloadTemplateId}")]
	Task DeleteOrganizationWebhooksPayloadTemplateAsync(
		string organizationId,
		string payloadTemplateId,
		CancellationToken cancellationToken = default);
}
