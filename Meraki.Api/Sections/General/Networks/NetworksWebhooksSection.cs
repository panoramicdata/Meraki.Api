namespace Meraki.Api.Sections.General.Networks;

public class NetworksWebhooksSection
{
	public INetworksWebhooksHttpServers HttpServers { get; internal set; } = null!;
	public INetworksWebhooksWebhookTests WebhookTests { get; internal set; } = null!;
}