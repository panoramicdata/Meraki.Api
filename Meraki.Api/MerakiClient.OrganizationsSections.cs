
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

	private OrganizationsSecureConnectSection BuildOrganizationsSecureConnectSection()
		=> new()
		{
			PrivateApplicationGroups = RefitFor(Organizations.SecureConnect.PrivateApplicationGroups),
			PrivateApplications = RefitFor(Organizations.SecureConnect.PrivateApplications),
			PrivateResourceGroups = RefitFor(Organizations.SecureConnect.PrivateResourceGroups),
			PrivateResources = RefitFor(Organizations.SecureConnect.PrivateResources),
			PublicApplications = RefitFor(Organizations.SecureConnect.PublicApplications),
			Regions = RefitFor(Organizations.SecureConnect.Regions),
			RemoteAccessLog = RefitFor(Organizations.SecureConnect.RemoteAccessLog),
			RemoteAccessLogsExports = RefitFor(Organizations.SecureConnect.RemoteAccessLogsExports),
			Sites = RefitFor(Organizations.SecureConnect.Sites)
		};

	private OrganizationsWirelessSection BuildOrganizationsWirelessSection()
		=> new()
		{
			LocationScanning = RefitFor(Organizations.Wireless.LocationScanning),
			Zigbee = RefitFor(Organizations.Wireless.Zigbee),
			Clients = RefitFor(Organizations.Wireless.Clients),
			Certificates = new()
			{
				OpenRoaming = RefitFor(Organizations.Wireless.Certificates.OpenRoaming)
			},
			Devices = BuildOrganizationsWirelessDevicesSection(),
			OpportunisticPcap = RefitFor(Organizations.Wireless.OpportunisticPcap),
			Mqtt = RefitFor(Organizations.Wireless.Mqtt),
			Ssids = BuildOrganizationsWirelessSsidsSection()
		};

	private OrganizationsApplianceDnsSection BuildOrganizationsApplianceDnsSection()
		=> new()
		{
			Local = BuildOrganizationsApplianceDnsLocalSection(),
			Split = new()
			{
				Profiles = RefitFor(Organizations.Appliance.Dns.Split.Profiles)
			}
		};

	private OrganizationsVpnSection BuildOrganizationsVpnSection()
		=> new()
		{
			SiteToSite = new()
			{
				Ipsec = RefitFor(Organizations.Appliance.Vpn.SiteToSite.Ipsec)
			}
		};

	private OrganizationsClientsSection BuildOrganizationsClientsSection()
		=> new()
		{
			Clients = RefitFor(Organizations.Clients.Clients),
			BandwidthUsageHistory = RefitFor(Organizations.Clients.BandwidthUsageHistory),
			Overview = RefitFor(Organizations.Clients.Overview),
		};

	private OrganizationsWebhooksSection BuildOrganizationsWebhooksSection()
		=> new()
		{
			AlertTypes = RefitFor(Organizations.Webhooks.AlertTypes),
			Callbacks = RefitFor(Organizations.Webhooks.Callbacks),
			Logs = RefitFor(Organizations.Webhooks.Logs),
			PayloadTemplates = RefitFor(Organizations.Webhooks.PayloadTemplates),
			HttpServers = RefitFor(Organizations.Webhooks.HttpServers),
			WebhookTests = RefitFor(Organizations.Webhooks.WebhookTests)
		};

	private OrganizationBrandingPoliciesSection BuildOrganizationsBrandingPoliciesSection()
		=> new()
		{
			BrandingPolicies = RefitFor(Organizations.BrandingPolicies.BrandingPolicies),
			Priorities = RefitFor(Organizations.BrandingPolicies.Priorities)
		};

	private OrganizationsSamlSection BuildOrganizationsSamlSection()
		=> new()
		{
			Saml = RefitFor(Organizations.Saml.Saml),
			Idp = RefitFor(Organizations.Saml.Idp)
		};

	private OrganizationsSummarySection BuildOrganizationsSummarySection()
		=> new()
		{
			Top = RefitFor(Organizations.Summary.Top),
			SwitchPower = RefitFor(Organizations.Summary.SwitchPower)
		};

	private OrganizationsCameraSection BuildOrganizationsCameraSection()
		=> new()
		{
			Permissions = RefitFor(Organizations.Camera.Permissions),
			Detections = RefitFor(Organizations.Camera.Detections)
		};

	private OrganizationsCampusGateway BuildOrganizationsCampusGatewaySection()
		=> new()
		{
			Clusters = RefitFor(Organizations.CampusGateway.Clusters),
			Devices = BuildOrganizationsCampusGatewayDevicesSection()
		};

	private OrganizationsCertificatesSection BuildOrganizationsCertificatesSection()
		=> new()
		{
			Certificates = RefitFor(Organizations.Certificates.Certificates),
			RadSec = BuildOrganizationsCertificatesRadSecSection()
		};

	private OrganizationsCertificatesRadSecSection BuildOrganizationsCertificatesRadSecSection()
		=> new()
		{
			DeviceCertificateAuthorities = RefitFor(Organizations.Certificates.RadSec.DeviceCertificateAuthorities)
		};

	private OrganizationsCloudSection BuildOrganizationsCloudSection()
		=> new()
		{
			Connectivity = RefitFor(Organizations.Cloud.Connectivity)
		};

	private OrganizationsExtensionsSection BuildOrganizationsExtensionsSection()
		=> new()
		{
			SdwanManager = new()
			{
				Interconnects = RefitFor(Organizations.Extensions.SdwanManager.Interconnects)
			},
			ThousandEyes = RefitFor(Organizations.Extensions.ThousandEyes)
		};

	private OrganizationsInsightSection BuildOrganizationsInsightSection()
		=> new()
		{
			Insight = RefitFor(Organizations.Insight.Insight),
			Applications = RefitFor(Organizations.Insight.Applications),
			WebApps = RefitFor(Organizations.Insight.WebApps)
		};

	private OrganizationsIntegrationsSection BuildOrganizationsIntegrationsSection()
		=> new()
		{
			Xdr = RefitFor(Organizations.Integrations.Xdr)
		};

	private OrganizationsInventorySection BuildOrganizationsInventorySection()
		=> new()
		{
			Onboarding = new()
			{
				CloudMonitoring = RefitFor(Organizations.Inventory.Onboarding.CloudMonitoring)
			},
			Orders = RefitFor(Organizations.Inventory.Orders)
		};

	private OrganizationsNacSection BuildOrganizationsNacSection()
		=> new()
		{
			Authorization = RefitFor(Organizations.Nac.Authorization),
			Sessions = RefitFor(Organizations.Nac.Sessions)
		};

	private OrganizationsPoliciesSection BuildOrganizationsPoliciesSection()
		=> new()
		{
			Assignments = RefitFor(Organizations.Policies.Assignments)
		};

	private OrganizationsSaseSection BuildOrganizationsSaseSection()
		=> new()
		{
			Connectivity = RefitFor(Organizations.Sase.Connectivity)
		};

	private OrganizationsSmSection BuildOrganizationsSmSection()
		=> new()
		{
			Admins = RefitFor(Organizations.Sm.Admins),
			Apple = RefitFor(Organizations.Sm.Apple),
			BulkEnrollment = RefitFor(Organizations.Sm.BulkEnrollment),
			Sentry = RefitFor(Organizations.Sm.Sentry)
		};

	private OrganizationsSpacesSection BuildOrganizationsSpacesSection()
		=> new()
		{
			Integration = RefitFor(Organizations.Spaces.Integration)
		};

	private OrganizationsWirelessControllerSection BuildOrganizationsWirelessControllerSection()
		=> new()
		{
			WirelessController = RefitFor(Organizations.WirelessController.WirelessController),
			Connections = RefitFor(Organizations.WirelessController.Connections),
			Clients = BuildOrganizationsWirelessControllerClientsSection(),
			Devices = BuildOrganizationsWirelessControllerDevicesSection(),
			Availabilities = RefitFor(Organizations.WirelessController.Availabilities),
			Overview = RefitFor(Organizations.WirelessController.Overview)
		};

	private OrganizationsWirelessControllerClientsSection BuildOrganizationsWirelessControllerClientsSection()
		=> new()
		{
			Overview = BuildOrganizationsWirelessControllerClientsOverviewSection()
		};

	private OrganizationsWirelessControllerDevicesSection BuildOrganizationsWirelessControllerDevicesSection()
		=> new()
		{
			Interfaces = BuildOrganizationsWirelessControllerDevicesInterfacesSection(),
			Redundancy = RefitFor(Organizations.WirelessController.Devices.Redundancy),
			System = BuildOrganizationsWirelessControllerDevicesSystemSection()
		};
	private NetworksAlertsSection BuildNetworksAlertsSection()
		=> new()
		{
			NetworksAlerts = RefitFor(Networks.Alerts.NetworksAlerts),
			Settings = RefitFor(Networks.Alerts.Settings)
		};

	private OrganizationsApiPushSection BuildOrganizationsApiPushSection()
		=> new()
		{
			Topics = RefitFor(Organizations.Api.Push.Topics),
			Receivers = new()
			{
				Profiles = RefitFor(Organizations.Api.Push.Receivers.Profiles)
			},
			Profiles = RefitFor(Organizations.Api.Push.Profiles)
		};

	private OrganizationsConfigTemplatesSwitchSection BuildOrganizationsConfigTemplatesSwitchSection()
		=> new()
		{
			Profiles = new()
			{
				Ports = new()
				{
					Mirrors = RefitFor(Organizations.ConfigTemplates.Switch.Profiles.Ports.Mirrors)
				}
			}
		};

	private OrganizationsDevicesSystemSection BuildOrganizationsDevicesSystemSection()
		=> new()
		{
			System = RefitFor(Organizations.Devices.System.System),
			Memory = new()
			{
				Usage = new()
				{
					History = RefitFor(Organizations.Devices.System.Memory.Usage.History),
				}
			}
		};

	private OrganizationsDevicesSyslogSection BuildOrganizationsDevicesSyslogSection()
		=> new()
		{
			Servers = new()
			{
				Roles = RefitFor(Organizations.Devices.Syslog.Servers.Roles),
			}
		};

	private OrganizationsWirelessDevicesSection BuildOrganizationsWirelessDevicesSection()
		=> new()
		{
			ChannelUtilization = RefitFor(Organizations.Wireless.Devices.ChannelUtilization),
			Latency = RefitFor(Organizations.Wireless.Devices.Latency),
			PacketLoss = RefitFor(Organizations.Wireless.Devices.PacketLoss),
			Radio = RefitFor(Organizations.Wireless.Devices.Radio),
			Radsec = new()
			{
				Certificates = RefitFor(Organizations.Wireless.Devices.Radsec.Certificates)
			}
		};

	private OrganizationsWirelessSsidsSection BuildOrganizationsWirelessSsidsSection()
		=> new()
		{
			Firewall = new()
			{
				Isolation = RefitFor(Organizations.Wireless.Ssids.Firewall.Isolation)
			}
		};

	private OrganizationsApplianceDnsLocalSection BuildOrganizationsApplianceDnsLocalSection()
		=> new()
		{
			Profiles = RefitFor(Organizations.Appliance.Dns.Local.Profiles),
			Records = RefitFor(Organizations.Appliance.Dns.Local.Records)
		};

	private OrganizationsCampusGatewayDevices BuildOrganizationsCampusGatewayDevicesSection()
		=> new()
		{
			Uplinks = new()
			{
				LocalOverrides = RefitFor(Organizations.CampusGateway.Devices.Uplinks.LocalOverrides)
			}
		};

	private OrganizationsWirelessControllerClientsOverview BuildOrganizationsWirelessControllerClientsOverviewSection()
		=> new()
		{
			History = new()
			{
				ByDevice = RefitFor(Organizations.WirelessController.Clients.Overview.History.ByDevice)
			}
		};

	private OrganizationsWirelessControllerDevicesInterfacesSection BuildOrganizationsWirelessControllerDevicesInterfacesSection()
		=> new()
		{
			L2 = RefitFor(Organizations.WirelessController.Devices.Interfaces.L2),
			L3 = RefitFor(Organizations.WirelessController.Devices.Interfaces.L3),
			Packets = RefitFor(Organizations.WirelessController.Devices.Interfaces.Packets),
			Usage = RefitFor(Organizations.WirelessController.Devices.Interfaces.Usage)
		};

	private OrganizationsWirelessControllerDevicesSystemSection BuildOrganizationsWirelessControllerDevicesSystemSection()
		=> new()
		{
			Utilization = new()
			{
				History = RefitFor(Organizations.WirelessController.Devices.System.Utilization.History)
			}
		};
}
#pragma warning restore S2333
