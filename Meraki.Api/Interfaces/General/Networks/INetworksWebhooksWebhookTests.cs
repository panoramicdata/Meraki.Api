﻿namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksWebhooksWebhookTests
{
	/// <summary>
	/// Return the status of a webhook test for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="webhookTestId">The id of a webhook test</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/webhooks/webhookTests/{webhookTestId}")]
	Task<WebhookTestResponse> GetNetworkWebhooksWebhookTestAsync(
		string networkId,
		string webhookTestId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Send a test webhook for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="webhookTestRequest">Body for creating a network HTTP server webhook test</param>
	/// <param name="cancellationToken"></param>
	[Post("/networks/{networkId}/webhooks/webhookTests")]
	Task<WebhookTestResponse> CreateNetworkWebhooksWebhookTestAsync(
		string networkId,
		[Body] WebhookTestRequest webhookTestRequest,
		CancellationToken cancellationToken = default
		);
}
