namespace Meraki.Api.Sections.General.Organizations;

public partial class OrganizationsSection
{
	[RefitPromoteCalls]
	internal IOrganizations Organizations { get; set; } = null!;

	public IOrganizationsAdmins Admins { get; internal set; } = null!;

	public IOrganizationsActionBatches ActionBatches { get; internal set; } = null!;

	public OrganizationsAdaptivePolicySection AdaptivePolicy { get; internal set; } = new();

	public IOrganizationsApiRequests ApiRequests { get; internal set; } = null!;

	public IOrganizationsClients Clients { get; internal set; } = null!;

	public IOrganizationsConfigTemplates ConfigTemplates { get; internal set; } = null!;

	public IOrganizationsConfigurationChanges ConfigurationChanges { get; internal set; } = null!;

	public IOrganizationsDevices Devices { get; internal set; } = null!;

	public IOrganizationsDevicesAvailabilitiesHistories DevicesAvailabilitiesHistories { get; internal set; } = null!;

	public OrganizationsEarlyAccessSection EarlyAccess { get; internal set; } = new();

	public IOrganizationsInventoryDevices InventoryDevices { get; internal set; } = null!;

	public IOrganizationsLicenses Licenses { get; internal set; } = null!;

	public IOrganizationsLoginSecurity LoginSecurity { get; internal set; } = null!;

	public IOrganizationsNetworks Networks { get; internal set; } = null!;

	public IOrganizationsOpenapiSpec OpenapiSpec { get; internal set; } = null!;

	public IOrganizationsPolicyObjects PolicyObjects { get; internal set; } = null!;

	public IOrganizationsPolicyObjectsGroups PolicyObjectGroups { get; internal set; } = null!;

	public OrganizationsSamlSection Saml { get; internal set; } = new();

	public IOrganizationsSamlRoles SamlRoles { get; internal set; } = null!;

	public IOrganizationsSnmp Snmp { get; internal set; } = null!;

	public OrganizationsSummarySection Summary { get; internal set; } = new();

	public IOrganizationSwitches Switches { get; internal set; } = null!;

	public OrganizationsWebhooksSection Webhooks { get; internal set; } = new();

	public OrganizationBrandingPoliciesSection BrandingPolicies { get; internal set; } = new();
}