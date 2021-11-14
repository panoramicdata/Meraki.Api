namespace Meraki.Api.Sections.General.Organizations;

public class OrganizationsSection
{
	public IOrganizations Organizations { get; internal set; } = null!;
	public IOrganizationsActionBatches ActionBatches { get; internal set; } = null!;
	public OrganizationsAdaptivePolicySection AdaptivePolicy { get; internal set; } = new();
	public IOrganizationsAdmins Admins { get; internal set; } = null!;
	public IOrganizationsApiRequests ApiRequests { get; internal set; } = null!;
	public IOrganizationsConfigTemplates ConfigTemplates { get; internal set; } = null!;
	public IOrganizationsConfigurationChanges ConfigurationChanges { get; internal set; } = null!;
	public IOrganizationsDevices Devices { get; internal set; } = null!;
	public IOrganizationsInventoryDevices InventoryDevices { get; internal set; } = null!;
	public IOrganizationsLoginSecurity LoginSecurity { get; internal set; } = null!;
	public IOrganizationsNetworks Networks { get; internal set; } = null!;
	public IOrganizationsLicenses Licenses { get; internal set; } = null!;
	public OrganizationsSamlSection Saml { get; internal set; } = new();
	public IOrganizationsSnmp Snmp { get; internal set; } = null!;
	public OrganizationsWebhooksSection Webhooks { get; internal set; } = new();
	public OrganizationBrandingPoliciesSection BrandingPolicies { get; internal set; } = new();
}
