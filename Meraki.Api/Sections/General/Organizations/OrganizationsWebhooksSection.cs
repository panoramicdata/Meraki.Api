namespace Meraki.Api.Sections.General.Organizations;

public class OrganizationsWebhooksSection
{
	public IOrganizationsWebhooksAlertTypes AlertTypes { get; internal set; } = null!;

	public IOrganizationsWebhooksLogs Logs { get; internal set; } = null!;

	public IOrganizationsWebhooksPayloadTemplates PayloadTemplates { get; internal set; } = null!;

	public IOrganizationsWebhooksHttpServers HttpServers { get; internal set; } = null!;

	public IOrganizationsWebhooksCallbacks Callbacks { get; internal set; } = null!;
}
