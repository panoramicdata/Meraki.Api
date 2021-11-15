namespace Meraki.Api.Sections.General.Organizations;

public class OrganizationsWebhooksSection
{
	public IOrganizationsWebhooksAlertTypes AlertTypes { get; internal set; } = null!;
	public IOrganizationsWebhooksLogs Logs { get; internal set; } = null!;
}
