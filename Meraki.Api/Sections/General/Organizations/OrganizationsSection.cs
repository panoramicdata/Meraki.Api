// <summary>
// Represents the root section for all organization-related API endpoints and sub-sections.
// </summary>
namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to all organization-level API endpoints and sub-sections.
/// </summary>
public partial class OrganizationsSection
{
	/// <summary>
	/// Main interface for organization-level operations.
	/// </summary>
	[RefitPromoteCalls]
	internal IOrganizations Organizations { get; set; } = null!;

	/// <summary>
	/// Interface for managing organization administrators.
	/// </summary>
	public IOrganizationsAdmins Admins { get; internal set; } = null!;

	/// <summary>
	/// Interface for managing action batches within the organization.
	/// </summary>
	public IOrganizationsActionBatches ActionBatches { get; internal set; } = null!;

	/// <summary>
	/// Section for adaptive policy operations.
	/// </summary>
	public OrganizationsAdaptivePolicySection AdaptivePolicy { get; internal set; } = new();

	/// <summary>
	/// Interface for accessing API request logs and statistics.
	/// </summary>
	public IOrganizationsApiRequests ApiRequests { get; internal set; } = null!;

	/// <summary>
	/// Interface for retrieving appliance security events.
	/// </summary>
	public IOrganizationsApplianceSecurityEvents ApplianceSecurityEvents { get; internal set; } = null!;

	/// <summary>
	/// Section for appliance-related operations.
	/// </summary>
	public OrganizationsApplianceSection Appliance { get; internal set; } = new();

	/// <summary>
	/// Interface for assurance health alerts.
	/// </summary>
	public IOrganizationsAssuranceAlerts AssuranceAlerts { get; internal set; } = null!;

	/// <summary>
	/// Interface for assurance product announcements and taxonomy.
	/// </summary>
	public IOrganizationsAssurance Assurance { get; internal set; } = null!;

	/// <summary>
	/// Section for camera-related operations.
	/// </summary>
	public OrganizationsCameraSection Camera { get; internal set; } = new();

	/// <summary>
	/// Section for campus gateway operations.
	/// </summary>
	public OrganizationsCampusGateway CampusGateway { get; internal set; } = new();

	/// <summary>
	/// Section for certificate management.
	/// </summary>
	public OrganizationsCertificatesSection Certificates { get; internal set; } = null!;

	/// <summary>
	/// Interface for client search and details.
	/// </summary>
	public IOrganizationsClients Clients { get; internal set; } = null!;

	/// <summary>
	/// Section for cloud-related operations.
	/// </summary>
	public OrganizationsCloudSection Cloud { get; internal set; } = new();

	/// <summary>
	/// Section for configuration templates.
	/// </summary>
	public OrganizationsConfigTemplatesSection ConfigTemplates { get; internal set; } = null!;

	/// <summary>
	/// Interface for configuration change logs.
	/// </summary>
	public IOrganizationsConfigurationChanges ConfigurationChanges { get; internal set; } = null!;

	/// <summary>
	/// Section for device management.
	/// </summary>
	public OrganizationsDeviceSection Devices { get; internal set; } = null!;

	/// <summary>
	/// Section for early access features.
	/// </summary>
	public OrganizationsEarlyAccessSection EarlyAccess { get; internal set; } = new();

	/// <summary>
	/// Section for extensions.
	/// </summary>
	public OrganizationsExtensionsSection Extensions { get; internal set; } = new();

	/// <summary>
	/// Interface for firmware upgrade information.
	/// </summary>
	public IOrganizationsFirmware Firmware { get; internal set; } = null!;

	/// <summary>
	/// Section for network insight features.
	/// </summary>
	public OrganizationsInsightSection Insight { get; internal set; } = new();

	/// <summary>
	/// Section for integrations.
	/// </summary>
	public OrganizationsIntegrationsSection Integrations { get; internal set; } = new();

	/// <summary>
	/// Section for inventory management.
	/// </summary>
	public OrganizationsInventorySection Inventory { get; internal set; } = new();

	/// <summary>
	/// Interface for inventory device operations.
	/// </summary>
	public IOrganizationsInventoryDevices InventoryDevices { get; internal set; } = null!;

	/// <summary>
	/// Interface for license management.
	/// </summary>
	public IOrganizationsLicenses Licenses { get; internal set; } = null!;

	/// <summary>
	/// Interface for login security settings.
	/// </summary>
	public IOrganizationsLoginSecurity LoginSecurity { get; internal set; } = null!;

	/// <summary>
	/// Section for NAC (Network Access Control) operations.
	/// </summary>
	public OrganizationsNacSection Nac { get; internal set; } = new();

	/// <summary>
	/// Interface for network management.
	/// </summary>
	public IOrganizationsNetworks Networks { get; internal set; } = null!;

	/// <summary>
	/// Interface for network device policies.
	/// </summary>
	public IOrganizationsNetworkDevices NewtworkDevices { get; set; } = null!;

	/// <summary>
	/// Interface for OpenAPI specification retrieval.
	/// </summary>
	public IOrganizationsOpenapiSpec OpenapiSpec { get; internal set; } = null!;

	/// <summary>
	/// Section for policy management.
	/// </summary>
	public OrganizationsPoliciesSection Policies { get; set; } = new();

	/// <summary>
	/// Interface for policy object management.
	/// </summary>
	public IOrganizationsPolicyObjects PolicyObjects { get; internal set; } = null!;

	/// <summary>
	/// Interface for policy object group management.
	/// </summary>
	public IOrganizationsPolicyObjectsGroups PolicyObjectGroups { get; internal set; } = null!;

	/// <summary>
	/// Section for SASE (Secure Access Service Edge) operations.
	/// </summary>
	public OrganizationsSaseSection Sase { get; internal set; } = new();

	/// <summary>
	/// Section for SAML (Security Assertion Markup Language) operations.
	/// </summary>
	public OrganizationsSamlSection Saml { get; internal set; } = new();

	/// <summary>
	/// Interface for SAML role management.
	/// </summary>
	public IOrganizationsSamlRoles SamlRoles { get; internal set; } = null!;

	/// <summary>
	/// Interface for sensor alert and reading operations.
	/// </summary>
	public IOrganizationsSensor Sensor { get; internal set; } = null!;

	/// <summary>
	/// Section for Secure Connect operations.
	/// </summary>
	public OrganizationsSecureConnectSection SecureConnect { get; internal set; } = new();

	/// <summary>
	/// Section for Systems Manager (SM) operations.
	/// </summary>
	public OrganizationsSmSection Sm { get; internal set; } = new();

	/// <summary>
	/// Interface for SNMP settings and traps.
	/// </summary>
	public IOrganizationsSnmp Snmp { get; internal set; } = null!;

	/// <summary>
	/// Section for Spaces operations.
	/// </summary>
	public OrganizationsSpacesSection Spaces { get; set; } = new();

	/// <summary>
	/// Interface for Splash page and theme management.
	/// </summary>
	public IOrganizationsSplash Splash { get; internal set; } = null!;

	/// <summary>
	/// Section for summary information.
	/// </summary>
	public OrganizationsSummarySection Summary { get; internal set; } = new();

	/// <summary>
	/// Interface for support operations.
	/// </summary>
	public IOrganizationsSupport Support { get; internal set; } = null!;

	/// <summary>
	/// Interface for switch management.
	/// </summary>
	public IOrganizationSwitches Switches { get; internal set; } = null!;

	/// <summary>
	/// Interface for switch ports overview.
	/// </summary>
	public IOrganizationsSwitchPortsOverview SwitchPortsOverview { get; internal set; } = null!;

	/// <summary>
	/// Interface for uplink management.
	/// </summary>
	public IOrganizationsUplinks Uplinks { get; internal set; } = null!;

	/// <summary>
	/// Section for webhooks management.
	/// </summary>
	public OrganizationsWebhooksSection Webhooks { get; internal set; } = new();

	/// <summary>
	/// Section for wireless operations.
	/// </summary>
	public OrganizationsWirelessSection Wireless { get; internal set; } = new();

	/// <summary>
	/// Section for wireless controller operations.
	/// </summary>
	public OrganizationsWirelessControllerSection WirelessController { get; internal set; } = new();

	/// <summary>
	/// Section for branding policies.
	/// </summary>
	public OrganizationBrandingPoliciesSection BrandingPolicies { get; internal set; } = new();
}
