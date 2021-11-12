namespace Meraki.Api.Sections.General.Organizations;

public class OrganizationsSection
{
	public IOrganizations Organizations { get; internal set; } = null!;
	public IActionBatches ActionBatches { get; internal set; } = null!;
	public OrganizationsAdaptivePolicySection AdaptivePolicy { get; internal set; } = new();
	public IOrganizationsDevices Devices { get; internal set; } = null!;
	public IOrganizationsInventoryDevices InventoryDevices { get; internal set; } = null!;
	public IOrganizationsLoginSecurity LoginSecurity { get; internal set; } = null!;
	public IOrganizationsNetworks Networks { get; internal set; } = null!;
	public IOrganizationsLicenses Licenses { get; internal set; } = null!;
	public OrganizationsSamlSection Saml { get; internal set; } = new();
	public IOrganizationsSnmp Snmp { get; internal set; } = null!;
	public OrganizationsWebhooksSection Webhooks { get; internal set; } = new();
}
