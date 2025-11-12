namespace Meraki.Api.Sections.General.Networks;

/// <summary>
/// Provides access to networks webhooks API endpoints
/// </summary>
public class NetworksWebhooksSection
{
	/// <summary>
	/// Return an HTTP server for a network
	/// </summary>

	public INetworksWebhooksHttpServers HttpServers { get; internal set; } = null!;

	/// <summary>
	/// Return the status of a webhook test for a network
	/// </summary>

	public INetworksWebhooksWebhookTests WebhookTests { get; internal set; } = null!;

	/// <summary>
	/// Return the list of network webhook payload templates
	/// </summary>

	public INetworksWebhooksPayloadTemplates PayloadTemplates { get; internal set; } = null!;
}
