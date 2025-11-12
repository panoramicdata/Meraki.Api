namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations webhooks API endpoints
/// </summary>
public class OrganizationsWebhooksSection
{
	/// <summary>
	/// Return a list of alert types to be used with managing webhook alerts
	/// </summary>

	public IOrganizationsWebhooksAlertTypes AlertTypes { get; internal set; } = null!;

	/// <summary>
	/// Return the log of webhook POSTs sent
	/// </summary>

	public IOrganizationsWebhooksLogs Logs { get; internal set; } = null!;

	/// <summary>
	/// List the webhook payload templates for an organization
	/// </summary>

	public IOrganizationsWebhooksPayloadTemplates PayloadTemplates { get; internal set; } = null!;

	/// <summary>
	/// Return an HTTP server for an organization
	/// </summary>

	public IOrganizationsWebhooksHttpServers HttpServers { get; internal set; } = null!;

	/// <summary>
	/// Return the status of an API callback
	/// </summary>

	public IOrganizationsWebhooksCallbacks Callbacks { get; internal set; } = null!;

	/// <summary>
	/// Send a test webhook for an organization
	/// </summary>

	public IOrganizationsWebhooksWebhookTests WebhookTests { get; internal set; } = null!;
}
