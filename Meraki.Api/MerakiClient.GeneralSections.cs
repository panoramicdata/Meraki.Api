namespace Meraki.Api;

/// <summary>
/// Builds the general-level API sections: devices, organizations and networks.
/// </summary>
/// <remarks>
/// These are separated from the constructor, which was otherwise 555 lines of wiring. Each builder
/// reads the section property it is about to replace, because <c>RefitFor</c> uses the value only
/// to infer the interface type to generate an implementation for.
/// </remarks>
// Codacy analyses each file on its own, so it cannot see the other parts of this class and reports
// 'partial' as gratuitous (S2333). The remaining parts live in the sibling MerakiClient files.
#pragma warning disable S2333
public partial class MerakiClient
{
	private DevicesSection BuildDevicesSection()
		=> new()
		{
			Devices = RefitFor(Devices.Devices),
			Appliance = BuildDevicesApplianceSection(),
			CellularSims = RefitFor(Devices.CellularSims),
			Clients = RefitFor(Devices.Clients),
			LldpCdp = RefitFor(Devices.LldpCdp),
			LossAndLatencyHistory = RefitFor(Devices.LossAndLatencyHistory),
			ManagementInterface = RefitFor(Devices.ManagementInterface),
			SensorCommands = RefitFor(Devices.SensorCommands),
			Wireless = BuildDevicesWirelessSection(),
		};

	private DevicesApplianceSection BuildDevicesApplianceSection()
		=> new()
		{
			Prefixes = RefitFor(Devices.Appliance.Prefixes)
		};

	private DevicesWirelessSection BuildDevicesWirelessSection()
		=> new()
		{
			DevicesWireless = RefitFor(Devices.Wireless.DevicesWireless),
			AlternateManagementInterface = RefitFor(Devices.Wireless.AlternateManagementInterface),
			Radio = BuildDevicesWirelessRadioSection(),
			Zigbee = BuildDevicesWirelessZigbeeSection()
		};

	private DevicesWirelessRadioSection BuildDevicesWirelessRadioSection()
		=> new()
		{
			Afc = RefitFor(Devices.Wireless.Radio.Afc)
		};

	private DevicesWirelessZigbeeSection BuildDevicesWirelessZigbeeSection()
		=> new()
		{
			Enrollments = RefitFor(Devices.Wireless.Zigbee.Enrollments)
		};

	private OrganizationsSection BuildOrganizationsSection()
		=> new()
		{
			Organizations = RefitFor(Organizations.Organizations),
			Admins = RefitFor(Organizations.Admins),
			ActionBatches = RefitFor(Organizations.ActionBatches),
			AdaptivePolicy = BuildOrganizationsAdaptivePolicySection(),
			Api = BuildOrganizationsApiSection(),
			ApiRequests = RefitFor(Organizations.ApiRequests),
			Appliance = BuildOrganizationsApplianceSection(),
			ApplianceSecurityEvents = RefitFor(Organizations.ApplianceSecurityEvents),
			Assurance = RefitFor(Organizations.Assurance),
			AssuranceAlerts = RefitFor(Organizations.AssuranceAlerts),
			BrandingPolicies = BuildOrganizationsBrandingPoliciesSection(),
			Camera = BuildOrganizationsCameraSection(),
			CampusGateway = BuildOrganizationsCampusGatewaySection(),
			Certificates = BuildOrganizationsCertificatesSection(),
			Clients = BuildOrganizationsClientsSection(),
			Cloud = BuildOrganizationsCloudSection(),
			ConfigurationChanges = RefitFor(Organizations.ConfigurationChanges),
			ConfigTemplates = BuildOrganizationsConfigTemplatesSection(),
			Devices = BuildOrganizationsDevicesSection(),
			EarlyAccess = new()
			{
				Features = RefitFor(Organizations.EarlyAccess.Features)
			},
			Extensions = BuildOrganizationsExtensionsSection(),
			Firmware = RefitFor(Organizations.Firmware),
			Insight = BuildOrganizationsInsightSection(),
			Integrations = BuildOrganizationsIntegrationsSection(),
			Inventory = BuildOrganizationsInventorySection(),
			InventoryDevices = RefitFor(Organizations.InventoryDevices),
			Licenses = RefitFor(Organizations.Licenses),
			LoginSecurity = RefitFor(Organizations.LoginSecurity),
			Nac = BuildOrganizationsNacSection(),
			Networks = RefitFor(Organizations.Networks),
			NewtworkDevices = RefitFor(Organizations.NewtworkDevices),
			OpenapiSpec = RefitFor(Organizations.OpenapiSpec),
			Policies = BuildOrganizationsPoliciesSection(),
			PolicyObjects = RefitFor(Organizations.PolicyObjects),
			PolicyObjectGroups = RefitFor(Organizations.PolicyObjectGroups),
			Saml = BuildOrganizationsSamlSection(),
			SamlRoles = RefitFor(Organizations.SamlRoles),
			Sase = BuildOrganizationsSaseSection(),
			SecureConnect = BuildOrganizationsSecureConnectSection(),
			Sensor = RefitFor(Organizations.Sensor),
			Sm = BuildOrganizationsSmSection(),
			Snmp = RefitFor(Organizations.Snmp),
			Spaces = BuildOrganizationsSpacesSection(),
			Splash = RefitFor(Organizations.Splash),
			Summary = BuildOrganizationsSummarySection(),
			Support = RefitFor(Organizations.Support),
			Switches = RefitFor(Organizations.Switches),
			SwitchPortsOverview = RefitFor(Organizations.SwitchPortsOverview),
			Uplinks = RefitFor(Organizations.Uplinks),
			Webhooks = BuildOrganizationsWebhooksSection(),
			Wireless = BuildOrganizationsWirelessSection(),
			WirelessController = BuildOrganizationsWirelessControllerSection()
		};

	private NetworksSection BuildNetworksSection()
		=> new()
		{
			Networks = RefitFor(Networks.Networks),
			Alerts = new()
			{
				NetworksAlerts = RefitFor(Networks.Alerts.NetworksAlerts),
				Settings = RefitFor(Networks.Alerts.Settings)
			},
			Appliance = new()
			{
				Umbrella = RefitFor(Networks.Appliance.Umbrella)
			},
			BluetoothClients = RefitFor(Networks.BluetoothClients),
			CampusGateway = RefitFor(Networks.CampusGateway),
			Clients = BuildNetworksClientsSection(),
			Devices = RefitFor(Networks.Devices),
			Events = BuildNetworksEventsSection(),
			FirmwareUpgrades = RefitFor(Networks.FirmwareUpgrades),
			Floorplans = RefitFor(Networks.Floorplans),
			GroupPolicies = RefitFor(Networks.GroupPolicies),
			Health = BuildNetworksHealthSection(),
			LocationScanning = RefitFor(Networks.LocationScanning),
			MerakiAuthUsers = RefitFor(Networks.MerakiAuthUsers),
			MqttBrokers = RefitFor(Networks.MqttBrokers),
			Netflow = RefitFor(Networks.Netflow),
			Pii = BuildNetworksPiiSection(),
			Policies = RefitFor(Networks.Policies),
			Sensor = BuildNetworksSensorSection(),
			Sm = RefitFor(Networks.Sm),
			Traffic = RefitFor(Networks.Traffic),
			Settings = RefitFor(Networks.Settings),
			Snmp = RefitFor(Networks.Snmp),
			SplashLoginAttempts = RefitFor(Networks.SplashLoginAttempts),
			Switch = BuildNetworksSwitchSection(),
			SyslogServers = RefitFor(Networks.SyslogServers),
			TrafficAnalysis = RefitFor(Networks.TrafficAnalysis),
			VlanProfiles = RefitFor(Networks.VlanProfiles),
			TrafficShaping = BuildNetworksTrafficShapingSection(),
			Webhooks = BuildNetworksWebhooksSection(),
			Wireless = BuildNetworksWirelessSection()
		};

	private NetworksSwitchSection BuildNetworksSwitchSection()
		=> new()
		{
			Ports = RefitFor(Networks.Switch.Ports),
			Dhcp = RefitFor(Networks.Switch.Dhcp),
			DhcpServerPolicy = RefitFor(Networks.Switch.DhcpServerPolicy),
			Stacks = RefitFor(Networks.Switch.Stacks)
		};

	private NetworksSensorSection BuildNetworksSensorSection()
		=> new()
		{
			Alerts = new()
			{
				Current = RefitFor(Networks.Sensor.Alerts.Current),
				Overview = RefitFor(Networks.Sensor.Alerts.Overview)
			},
			Schedules = RefitFor(Networks.Sensor.Schedules)
		};

	private NetworksWirelessSection BuildNetworksWirelessSection()
		=> new()
		{
			Clients = RefitFor(Networks.Wireless.Clients),
			Devices = RefitFor(Networks.Wireless.Devices),
			Location = RefitFor(Networks.Wireless.Location),
			OpportunisticPcap = RefitFor(Networks.Wireless.OpportunisticPcap),
			Radio = RefitFor(Networks.Wireless.Radio),
			Zigbee = RefitFor(Networks.Wireless.Zigbee)
		};
	private OrganizationsApiSection BuildOrganizationsApiSection()
		=> new()
		{
			Push = new()
			{
				Topics = RefitFor(Organizations.Api.Push.Topics),
				Receivers = new()
				{
					Profiles = RefitFor(Organizations.Api.Push.Receivers.Profiles)
				},
				Profiles = RefitFor(Organizations.Api.Push.Profiles)
			}
		};

	private OrganizationsConfigTemplatesSection BuildOrganizationsConfigTemplatesSection()
		=> new()
		{
			ConfigTemplates = RefitFor(Organizations.ConfigTemplates.ConfigTemplates),
			Switch = new()
			{
				Profiles = new()
				{
					Ports = new()
					{
						Mirrors = RefitFor(Organizations.ConfigTemplates.Switch.Profiles.Ports.Mirrors)
					}
				}
			}
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
			System = new()
			{
				System = RefitFor(Organizations.Devices.System.System),
				Memory = new()
				{
					Usage = new()
					{
						History = RefitFor(Organizations.Devices.System.Memory.Usage.History),
					}
				}
			},
			Syslog = new()
			{
				Servers = new()
				{
					Roles = RefitFor(Organizations.Devices.Syslog.Servers.Roles),
				}
			},
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
			Devices = new()
			{
				ChannelUtilization = RefitFor(Organizations.Wireless.Devices.ChannelUtilization),
				Latency = RefitFor(Organizations.Wireless.Devices.Latency),
				PacketLoss = RefitFor(Organizations.Wireless.Devices.PacketLoss),
				Radio = RefitFor(Organizations.Wireless.Devices.Radio),
				Radsec = new()
				{
					Certificates = RefitFor(Organizations.Wireless.Devices.Radsec.Certificates)
				}
			},
			OpportunisticPcap = RefitFor(Organizations.Wireless.OpportunisticPcap),
			Mqtt = RefitFor(Organizations.Wireless.Mqtt),
			Ssids = new()
			{
				Firewall = new()
				{
					Isolation = RefitFor(Organizations.Wireless.Ssids.Firewall.Isolation)
				}
			}
		};

	private NetworksClientsSection BuildNetworksClientsSection()
		=> new()
		{
			Clients = RefitFor(Networks.Clients.Clients),
			ApplicationUsage = RefitFor(Networks.Clients.ApplicationUsage),
			Policy = RefitFor(Networks.Clients.Policy),
			SplashAuthorizationStatus = RefitFor(Networks.Clients.SplashAuthorizationStatus),
			TrafficHistory = RefitFor(Networks.Clients.TrafficHistory),
			UsageHistories = RefitFor(Networks.Clients.UsageHistories),
			UsageHistory = RefitFor(Networks.Clients.UsageHistory)
		};
	private OrganizationsApplianceSection BuildOrganizationsApplianceSection()
		=> new()
		{
			Dns = BuildOrganizationsApplianceDnsSection(),
			Sdwan = RefitFor(Organizations.Appliance.Sdwan),
			Uplinks = new()
			{
				Usage = RefitFor(Organizations.Appliance.Uplinks.Usage)
			},
			Vlans = RefitFor(Organizations.Appliance.Vlans),
			Vpn = BuildOrganizationsVpnSection()
		};

	private OrganizationsApplianceDnsSection BuildOrganizationsApplianceDnsSection()
		=> new()
		{
			Local = new()
			{
				Profiles = RefitFor(Organizations.Appliance.Dns.Local.Profiles),
				Records = RefitFor(Organizations.Appliance.Dns.Local.Records)
			},
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

	private NetworksPiiSection BuildNetworksPiiSection()
		=> new()
		{
			PiiKeys = RefitFor(Networks.Pii.PiiKeys),
			Requests = RefitFor(Networks.Pii.Requests),
			SmDevicesForKey = RefitFor(Networks.Pii.SmDevicesForKey),
			SmOwnersForKey = RefitFor(Networks.Pii.SmOwnersForKey)
		};

	private NetworksWebhooksSection BuildNetworksWebhooksSection()
		=> new()
		{
			HttpServers = RefitFor(Networks.Webhooks.HttpServers),
			WebhookTests = RefitFor(Networks.Webhooks.WebhookTests),
			PayloadTemplates = RefitFor(Networks.Webhooks.PayloadTemplates)
		};
	private OrganizationsAdaptivePolicySection BuildOrganizationsAdaptivePolicySection()
		=> new()
		{
			Acls = RefitFor(Organizations.AdaptivePolicy.Acls),
			Settings = RefitFor(Organizations.AdaptivePolicy.Settings)
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

	private NetworksEventsSection BuildNetworksEventsSection()
		=> new()
		{
			Events = RefitFor(Networks.Events.Events),
			EventsTypes = RefitFor(Networks.Events.EventsTypes)
		};

	private NetworksHealthSection BuildNetworksHealthSection()
		=> new()
		{
			ChannelUtilization = RefitFor(Networks.Health.ChannelUtilization),
			HealthAlerts = RefitFor(Networks.Health.HealthAlerts)
		};

	private NetworksTrafficShapingSection BuildNetworksTrafficShapingSection()
		=> new()
		{
			ApplicationCategories = RefitFor(Networks.TrafficShaping.ApplicationCategories),
			DscpTaggingOptions = RefitFor(Networks.TrafficShaping.DscpTaggingOptions)
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
			Devices = new()
			{
				Uplinks = new()
				{
					LocalOverrides = RefitFor(Organizations.CampusGateway.Devices.Uplinks.LocalOverrides)
				}
			}
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
			Overview = new()
			{
				History = new()
				{
					ByDevice = RefitFor(Organizations.WirelessController.Clients.Overview.History.ByDevice)
				}
			}
		};

	private OrganizationsWirelessControllerDevicesSection BuildOrganizationsWirelessControllerDevicesSection()
		=> new()
		{
			Interfaces = new()
			{
				L2 = RefitFor(Organizations.WirelessController.Devices.Interfaces.L2),
				L3 = RefitFor(Organizations.WirelessController.Devices.Interfaces.L3),
				Packets = RefitFor(Organizations.WirelessController.Devices.Interfaces.Packets),
				Usage = RefitFor(Organizations.WirelessController.Devices.Interfaces.Usage)
			},
			Redundancy = RefitFor(Organizations.WirelessController.Devices.Redundancy),
			System = new()
			{
				Utilization = new()
				{
					History = RefitFor(Organizations.WirelessController.Devices.System.Utilization.History)
				}
			}
		};
}
#pragma warning restore S2333