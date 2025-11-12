namespace Meraki.Api.Interfaces.General.Organizations;
/// <summary>
/// I Organizations Webhooks Webhook Tests
/// </summary>
public interface IOrganizationsWebhooksWebhookTests
{
	/// <summary>
	/// Send a test webhook for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createOrganizationWebhooksWebhookTest")]
	[Post("/organizations/{organizationId}/webhooks/webhookTests")]
	Task<OrganizationWebhookTest> CreateOrganizationWebhooksWebhookTestAsync(
		string organizationId,
		[Body] OrganizationWebhookTestCreateRequest request,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Return the status of a webhook test for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="webhookTestId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWebhooksWebhookTest")]
	[Get("/organizations/{organizationId}/webhooks/webhookTests/{webhookTestId}")]
	Task<OrganizationWebhookTest> GetOrganizationWebhooksWebhookTestAsync(
		string organizationId,
		string webhookTestId,
		CancellationToken cancellationToken = default
	);
}
