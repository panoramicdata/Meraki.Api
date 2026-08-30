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
			CellularSims = RefitFor(Devices.CellularSims),
			Clients = RefitFor(Devices.Clients),
			LldpCdp = RefitFor(Devices.LldpCdp),
			LossAndLatencyHistory = RefitFor(Devices.LossAndLatencyHistory),
			ManagementInterface = RefitFor(Devices.ManagementInterface),
			SensorCommands = RefitFor(Devices.SensorCommands),
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
			AssuranceAlerts = RefitFor(Organizations.AssuranceAlerts),
			BrandingPolicies = BuildOrganizationsBrandingPoliciesSection(),
			Clients = BuildOrganizationsClientsSection(),
			ConfigurationChanges = RefitFor(Organizations.ConfigurationChanges),
			ConfigTemplates = BuildOrganizationsConfigTemplatesSection(),
			Devices = BuildOrganizationsDevicesSection(),
			EarlyAccess = new()
			{
				Features = RefitFor(Organizations.EarlyAccess.Features)
			},
			InventoryDevices = RefitFor(Organizations.InventoryDevices),
			Licenses = RefitFor(Organizations.Licenses),
			LoginSecurity = RefitFor(Organizations.LoginSecurity),
			Networks = RefitFor(Organizations.Networks),
			OpenapiSpec = RefitFor(Organizations.OpenapiSpec),
			PolicyObjects = RefitFor(Organizations.PolicyObjects),
			PolicyObjectGroups = RefitFor(Organizations.PolicyObjectGroups),
			Saml = BuildOrganizationsSamlSection(),
			SamlRoles = RefitFor(Organizations.SamlRoles),
			SecureConnect = BuildOrganizationsSecureConnectSection(),
			Snmp = RefitFor(Organizations.Snmp),
			Splash = RefitFor(Organizations.Splash),
			Summary = BuildOrganizationsSummarySection(),
			Switches = RefitFor(Organizations.Switches),
			SwitchPortsOverview = RefitFor(Organizations.SwitchPortsOverview),
			Uplinks = RefitFor(Organizations.Uplinks),
			Webhooks = BuildOrganizationsWebhooksSection(),
			Wireless = BuildOrganizationsWirelessSection()
		};

	private NetworksSection BuildNetworksSection()
		=> new()
		{
			Networks = RefitFor(Networks.Networks),
			Alerts = new()
			{
				Settings = RefitFor(Networks.Alerts.Settings)
			},
			BluetoothClients = RefitFor(Networks.BluetoothClients),
			Clients = BuildNetworksClientsSection(),
			Devices = RefitFor(Networks.Devices),
			Events = BuildNetworksEventsSection(),
			FirmwareUpgrades = RefitFor(Networks.FirmwareUpgrades),
			Floorplans = RefitFor(Networks.Floorplans),
			GroupPolicies = RefitFor(Networks.GroupPolicies),
			Health = BuildNetworksHealthSection(),
			MerakiAuthUsers = RefitFor(Networks.MerakiAuthUsers),
			MqttBrokers = RefitFor(Networks.MqttBrokers),
			Netflow = RefitFor(Networks.Netflow),
			Pii = BuildNetworksPiiSection(),
			Traffic = RefitFor(Networks.Traffic),
			Settings = RefitFor(Networks.Settings),
			Snmp = RefitFor(Networks.Snmp),
			SplashLoginAttempts = RefitFor(Networks.SplashLoginAttempts),
			SyslogServers = RefitFor(Networks.SyslogServers),
			TrafficAnalysis = RefitFor(Networks.TrafficAnalysis),
			VlanProfiles = RefitFor(Networks.VlanProfiles),
			TrafficShaping = BuildNetworksTrafficShapingSection(),
			Webhooks = BuildNetworksWebhooksSection()
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
			Devices = new()
			{
				ChannelUtilization = RefitFor(Organizations.Wireless.Devices.ChannelUtilization),
				Latency = RefitFor(Organizations.Wireless.Devices.Latency),
				PacketLoss = RefitFor(Organizations.Wireless.Devices.PacketLoss)
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
			Uplinks = new()
			{
				Usage = RefitFor(Organizations.Appliance.Uplinks.Usage)
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
			Logs = RefitFor(Organizations.Webhooks.Logs),
			PayloadTemplates = RefitFor(Organizations.Webhooks.PayloadTemplates),
			HttpServers = RefitFor(Organizations.Webhooks.HttpServers)
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
}
#pragma warning restore S2333