
namespace Meraki.Api;

/// <summary>
/// Builds the organization-level API sections.
/// </summary>
/// <remarks>
/// Separated from the constructor, which was otherwise 555 lines of wiring, and split by section so
/// that no single file passes the size limit. Each builder reads the section property it is about to
/// replace, because <c>RefitFor</c> uses that value only to infer the interface type to implement.
/// </remarks>
// Codacy analyses each file on its own, so it cannot see the other parts of this class and reports
// 'partial' as gratuitous (S2333). The remaining parts live in the sibling MerakiClient files.
#pragma warning disable S2333
public partial class MerakiClient
{
	private OrganizationsSection BuildOrganizationsSection()
	{
		var section = BuildOrganizationsClients();
		AddOrganizationsSubSections(section);

		return section;
	}

	/// <summary>
	/// The Refit clients the organizations section owns directly.
	/// </summary>
	private OrganizationsSection BuildOrganizationsClients()
		=> new()
		{
			Organizations = RefitFor(Organizations.Organizations),
			Admins = RefitFor(Organizations.Admins),
			ActionBatches = RefitFor(Organizations.ActionBatches),
			ApiRequests = RefitFor(Organizations.ApiRequests),
			ApplianceSecurityEvents = RefitFor(Organizations.ApplianceSecurityEvents),
			Assurance = RefitFor(Organizations.Assurance),
			AssuranceAlerts = RefitFor(Organizations.AssuranceAlerts),
			ConfigurationChanges = RefitFor(Organizations.ConfigurationChanges),
			Firmware = RefitFor(Organizations.Firmware),
			InventoryDevices = RefitFor(Organizations.InventoryDevices),
			Licenses = RefitFor(Organizations.Licenses),
			LoginSecurity = RefitFor(Organizations.LoginSecurity),
			Networks = RefitFor(Organizations.Networks),
			NewtworkDevices = RefitFor(Organizations.NewtworkDevices),
			OpenapiSpec = RefitFor(Organizations.OpenapiSpec),
			PolicyObjects = RefitFor(Organizations.PolicyObjects),
			PolicyObjectGroups = RefitFor(Organizations.PolicyObjectGroups),
			SamlRoles = RefitFor(Organizations.SamlRoles),
			Sensor = RefitFor(Organizations.Sensor),
			Snmp = RefitFor(Organizations.Snmp),
			Splash = RefitFor(Organizations.Splash),
			Support = RefitFor(Organizations.Support),
			Switches = RefitFor(Organizations.Switches),
			SwitchPortsOverview = RefitFor(Organizations.SwitchPortsOverview),
			Uplinks = RefitFor(Organizations.Uplinks),
		};

	/// <summary>
	/// The sub-sections that have builders of their own. Assigned after construction, rather than in
	/// the initializer above, only so that neither half passes the method length limit.
	/// </summary>
	private void AddOrganizationsSubSections(OrganizationsSection section)
	{
		section.AdaptivePolicy = BuildOrganizationsAdaptivePolicySection();
		section.Api = BuildOrganizationsApiSection();
		section.Appliance = BuildOrganizationsApplianceSection();
		section.BrandingPolicies = BuildOrganizationsBrandingPoliciesSection();
		section.Camera = BuildOrganizationsCameraSection();
		section.CampusGateway = BuildOrganizationsCampusGatewaySection();
		section.Certificates = BuildOrganizationsCertificatesSection();
		section.Clients = BuildOrganizationsClientsSection();
		section.Cloud = BuildOrganizationsCloudSection();
		section.ConfigTemplates = BuildOrganizationsConfigTemplatesSection();
		section.Devices = BuildOrganizationsDevicesSection();
		section.EarlyAccess = new()
		{
			Features = RefitFor(Organizations.EarlyAccess.Features)
		};
		section.Extensions = BuildOrganizationsExtensionsSection();
		section.Insight = BuildOrganizationsInsightSection();
		section.Integrations = BuildOrganizationsIntegrationsSection();
		section.Inventory = BuildOrganizationsInventorySection();
		section.Nac = BuildOrganizationsNacSection();
		section.Policies = BuildOrganizationsPoliciesSection();
		section.Saml = BuildOrganizationsSamlSection();
		section.Sase = BuildOrganizationsSaseSection();
		section.SecureConnect = BuildOrganizationsSecureConnectSection();
		section.Sm = BuildOrganizationsSmSection();
		section.Spaces = BuildOrganizationsSpacesSection();
		section.Summary = BuildOrganizationsSummarySection();
		section.Webhooks = BuildOrganizationsWebhooksSection();
		section.Wireless = BuildOrganizationsWirelessSection();
		section.WirelessController = BuildOrganizationsWirelessControllerSection();
	}

	private OrganizationsConfigTemplatesSection BuildOrganizationsConfigTemplatesSection()
		=> new()
		{
			ConfigTemplates = RefitFor(Organizations.ConfigTemplates.ConfigTemplates),
			Switch = BuildOrganizationsConfigTemplatesSwitchSection()
		};

	private OrganizationsDeviceSection BuildOrganizationsDevicesSection()
		=> new()
		{
			Devices = RefitFor(Organizations.Devices.Devices),
			Controller = RefitFor(Organizations.Devices.Controller),
			PacketCapture = RefitFor(Organizations.Devices.PacketCapture),
			Power = RefitFor(Organizations.Devices.Power),
			PowerModules = new()
			{
				Statuses = RefitFor(Organizations.Devices.PowerModules.Statuses)
			},
			SignalQuality = RefitFor(Organizations.Devices.SignalQuality),
			System = BuildOrganizationsDevicesSystemSection(),
			Syslog = BuildOrganizationsDevicesSyslogSection(),
			Uplinks = new()
			{
				Addresses = RefitFor(Organizations.Devices.Uplinks.Addresses),
			},
			WirelessControllers = RefitFor(Organizations.Devices.WirelessControllers)
		};
}
