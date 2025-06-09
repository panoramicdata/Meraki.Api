namespace Meraki.Api.Interfaces.General.Organizations;
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
}
