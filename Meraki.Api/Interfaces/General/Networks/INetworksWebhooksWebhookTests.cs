namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksWebhooksWebhookTests
{
	/// <summary>
	/// Return the status of a webhook test for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="webhookTestId">The id of a webhook test</param>
	[Get("/networks/{networkId}/webhooks/webhookTests/{webhookTestId}")]
	Task<WebhookTestResponse> GetNetworkWebhooksWebhookTestAsync(
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
	Task<WebhookTestResponse> CreateNetworkWebhooksWebhookTestAsync(
		[AliasAs("networkId")] string networkId,
		[Body] WebhookTestRequest webhookTestRequest,
		CancellationToken cancellationToken = default
		);
}
