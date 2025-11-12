using Meraki.Api.Extensions;
using Meraki.Api.Sections.General.LiveTools;
using Meraki.Api.Sections.Products.Licensing;
using Meraki.Api.Sections.SecureConnect;

namespace Meraki.Api;

/// <summary>
/// A Meraki Dashboard API client. This is your starting point for all API operations.
/// Example usage:
///
/// ```csharp
/// using Meraki.Api;
/// using System;
/// using System.Threading.Tasks;
///
/// namespace My.Project;
/// public static class Program
/// {
///     public static async Task Main()
///     {
///         using var merakiClient = new MerakiClient(
///             new MerakiClientOptions
///             {
///                 ApiKey = "0123456789abcdef0123456789abcdef01234567",
///                 UserAgent = "YourProductName/YourProductVersion YourCompanyName"
///             }
///         );
///
///         var organizations = await merakiClient
///             .Organizations
///             .GetOrganizationsAsync()
///             .ConfigureAwait(false);
///
///         var firstOrganization = organizations[0];
///
///         var devices = await merakiClient
///             .Organizations
///             .Devices
///             .GetOrganizationDevicesAsync(firstOrganization.Id)
///             .ConfigureAwait(false);
///
///         Console.WriteLine("Devices:");
///         foreach (var device in devices)
///         {
///             Console.WriteLine($"    - {device.Serial}: {device.Name}");
///         }
///     }
/// }
/// ```
/// </summary>
public partial class MerakiClient : IDisposable
{
	private readonly MerakiClientOptions _options;
	private readonly ILogger _logger;
	private readonly HttpClient _coreHttpClient;
	private readonly HttpClient _secureConnectHttpClient;
	private readonly AuthenticatedBackingOffHttpClientHandler _httpClientHandler;

	/// <summary>
	/// Gets the URI of the last API request made by this client
	/// </summary>
	public string LastRequestUri => _httpClientHandler.LastRequestUri;

	/// <summary>
	/// Gets statistics about API requests made by this client
	/// </summary>
	public MerakiClientStatistics Statistics => _httpClientHandler.Statistics;

	/// <summary>
	/// Gets the api client version
	/// </summary>

	public string ApiClientVersion { get; private set; }

	/// <summary>
	/// A Meraki portal client
	/// </summary>
	public MerakiClient(MerakiClientOptions options, ILogger? logger = default)
	{
		var apiClientVersion = new System.Version(ThisAssembly.AssemblyFileVersion);
		ApiClientVersion = $"{apiClientVersion.Major}.{apiClientVersion.Minor}.{apiClientVersion.Build}";

		_options = options;
		_logger = logger ?? NullLogger.Instance;
		_httpClientHandler = new AuthenticatedBackingOffHttpClientHandler(options ?? throw new ArgumentNullException(nameof(options)), this, _logger);

		var merakiDomain = options.ApiRegion.GetMerakiApiDomain()
			?? throw new ArgumentOutOfRangeException($"Unsupported API Region {options.ApiRegion}");

		// Set up the core HttpClient, this is used to communicate with most of the API
		_coreHttpClient = new HttpClient(_httpClientHandler)
		{
			BaseAddress = new Uri($"https://api.{merakiDomain}/api/v1"),
			Timeout = TimeSpan.FromSeconds(options.HttpClientTimeoutSeconds)
		};

		// Set up the SecureConnect HttpClient
		_secureConnectHttpClient = new HttpClient(_httpClientHandler)
		{
			BaseAddress = new Uri($"https://api.{merakiDomain}/api/secureConnect/v1"),
			Timeout = TimeSpan.FromSeconds(options.HttpClientTimeoutSeconds)
		};

		_refitSettings = new RefitSettings
		{
			ContentSerializer = new CustomNewtonsoftJsonContentSerializer(_options, _logger),
			CollectionFormat = CollectionFormat.Multi
		};

		// General level sections //
		Devices = new()
		{
			Devices = RefitFor(Devices.Devices),
			CellularSims = RefitFor(Devices.CellularSims),
			Clients = RefitFor(Devices.Clients),
			LldpCdp = RefitFor(Devices.LldpCdp),
			LossAndLatencyHistory = RefitFor(Devices.LossAndLatencyHistory),
			ManagementInterface = RefitFor(Devices.ManagementInterface),
			SensorCommands = RefitFor(Devices.SensorCommands),
		};

		Organizations = new OrganizationsSection
		{
			Organizations = RefitFor(Organizations.Organizations),
			Admins = RefitFor(Organizations.Admins),
			ActionBatches = RefitFor(Organizations.ActionBatches),
			AdaptivePolicy = new()
			{
				Acls = RefitFor(Organizations.AdaptivePolicy.Acls),
				Settings = RefitFor(Organizations.AdaptivePolicy.Settings)
			},
			ApiRequests = RefitFor(Organizations.ApiRequests),
			ApplianceSecurityEvents = RefitFor(Organizations.ApplianceSecurityEvents),
			AssuranceAlerts = RefitFor(Organizations.AssuranceAlerts),
			BrandingPolicies = new()
			{
				BrandingPolicies = RefitFor(Organizations.BrandingPolicies.BrandingPolicies),
				Priorities = RefitFor(Organizations.BrandingPolicies.Priorities)
			},
			Clients = RefitFor(Organizations.Clients),
			ConfigurationChanges = RefitFor(Organizations.ConfigurationChanges),
			ConfigTemplates = new()
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
			},
			Devices = new()
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
			},
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
			Saml = new()
			{
				Saml = RefitFor(Organizations.Saml.Saml),
				Idp = RefitFor(Organizations.Saml.Idp)
			},
			SamlRoles = RefitFor(Organizations.SamlRoles),
			SecureConnect = new()
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
			},
			Snmp = RefitFor(Organizations.Snmp),
			Splash = RefitFor(Organizations.Splash),
			Summary = new()
			{
				Top = RefitFor(Organizations.Summary.Top)
			},
			Switches = RefitFor(Organizations.Switches),
			SwitchPortsOverview = RefitFor(Organizations.SwitchPortsOverview),
			Uplinks = RefitFor(Organizations.Uplinks),
			Webhooks = new()
			{
				AlertTypes = RefitFor(Organizations.Webhooks.AlertTypes),
				Logs = RefitFor(Organizations.Webhooks.Logs),
				PayloadTemplates = RefitFor(Organizations.Webhooks.PayloadTemplates),
				HttpServers = RefitFor(Organizations.Webhooks.HttpServers)
			}
		};

		Networks = new()
		{
			Networks = RefitFor(Networks.Networks),
			Alerts = new()
			{
				Settings = RefitFor(Networks.Alerts.Settings)
			},
			BluetoothClients = RefitFor(Networks.BluetoothClients),
			Clients = new()
			{
				Clients = RefitFor(Networks.Clients.Clients),
				ApplicationUsage = RefitFor(Networks.Clients.ApplicationUsage),
				Policy = RefitFor(Networks.Clients.Policy),
				SplashAuthorizationStatus = RefitFor(Networks.Clients.SplashAuthorizationStatus),
				TrafficHistory = RefitFor(Networks.Clients.TrafficHistory),
				UsageHistories = RefitFor(Networks.Clients.UsageHistories),
				UsageHistory = RefitFor(Networks.Clients.UsageHistory)
			},
			Devices = RefitFor(Networks.Devices),
			Events = new()
			{
				Events = RefitFor(Networks.Events.Events),
				EventsTypes = RefitFor(Networks.Events.EventsTypes)
			},
			FirmwareUpgrades = RefitFor(Networks.FirmwareUpgrades),
			Floorplans = RefitFor(Networks.Floorplans),
			GroupPolicies = RefitFor(Networks.GroupPolicies),
			Health = new()
			{
				ChannelUtilization = RefitFor(Networks.Health.ChannelUtilization),
				HealthAlerts = RefitFor(Networks.Health.HealthAlerts)
			},
			MerakiAuthUsers = RefitFor(Networks.MerakiAuthUsers),
			MqttBrokers = RefitFor(Networks.MqttBrokers),
			Netflow = RefitFor(Networks.Netflow),
			Pii = new()
			{
				PiiKeys = RefitFor(Networks.Pii.PiiKeys),
				Requests = RefitFor(Networks.Pii.Requests),
				SmDevicesForKey = RefitFor(Networks.Pii.SmDevicesForKey),
				SmOwnersForKey = RefitFor(Networks.Pii.SmOwnersForKey)
			},
			Traffic = RefitFor(Networks.Traffic),
			Settings = RefitFor(Networks.Settings),
			Snmp = RefitFor(Networks.Snmp),
			SplashLoginAttempts = RefitFor(Networks.SplashLoginAttempts),
			SyslogServers = RefitFor(Networks.SyslogServers),
			TrafficAnalysis = RefitFor(Networks.TrafficAnalysis),
			VlanProfiles = RefitFor(Networks.VlanProfiles),
			TrafficShaping = new()
			{
				ApplicationCategories = RefitFor(Networks.TrafficShaping.ApplicationCategories),
				DscpTaggingOptions = RefitFor(Networks.TrafficShaping.DscpTaggingOptions)
			},
			Webhooks = new()
			{
				HttpServers = RefitFor(Networks.Webhooks.HttpServers),
				WebhookTests = RefitFor(Networks.Webhooks.WebhookTests),
				PayloadTemplates = RefitFor(Networks.Webhooks.PayloadTemplates)
			}
		};

		// Product level sections //
		Appliance = new()
		{
			Clients = new()
			{
				Security = RefitFor(Appliance.Clients.Security)
			},
			ConnectivityMonitoringDestinations = RefitFor(Appliance.ConnectivityMonitoringDestinations),
			ContentFiltering = new()
			{
				ContentFiltering = RefitFor(Appliance.ContentFiltering.ContentFiltering),
				Categories = RefitFor(Appliance.ContentFiltering.Categories)
			},
			Performance = RefitFor(Appliance.Performance),
			Ports = RefitFor(Appliance.Ports),
			Prefixes = new()
			{
				Delegated = new()
				{
					Statics = RefitFor(Appliance.Prefixes.Delegated.Statics)
				}
			},
			RadioSettings = RefitFor(Appliance.RadioSettings),
			RfProfiles = RefitFor(Appliance.RfProfiles),
			SdwanInternetPolices = RefitFor(Appliance.SdwanInternetPolices),
			Security = new()
			{
				Intrusion = RefitFor(Appliance.Security.Intrusion),
				Malware = RefitFor(Appliance.Security.Malware),
				Events = RefitFor(Appliance.Security.Events)
			},
			Settings = RefitFor(Appliance.Settings),
			SingleLan = RefitFor(Appliance.SingleLan),
			Dhpc = new()
			{
				Subnets = RefitFor(Appliance.Dhpc.Subnets)
			},
			DnsLocalProfiles = RefitFor(Appliance.DnsLocalProfiles),
			Firewall = new()
			{
				CellularFirewallRules = RefitFor(Appliance.Firewall.CellularFirewallRules),
				InboundCellularFirewallRules = RefitFor(Appliance.Firewall.InboundCellularFirewallRules),
				FirewalledServices = RefitFor(Appliance.Firewall.FirewalledServices),
				InboundFirewallRules = RefitFor(Appliance.Firewall.InboundFirewallRules),
				L3FirewallRules = RefitFor(Appliance.Firewall.L3FirewallRules),
				L7FirewallRules = RefitFor(Appliance.Firewall.L7FirewallRules),
				MulticastForwarding = RefitFor(Appliance.Firewall.MulticastForwarding),
				OneToManyNatRules = RefitFor(Appliance.Firewall.OneToManyNatRules),
				OneToOneNatRules = RefitFor(Appliance.Firewall.OneToOneNatRules),
				PortForwardingRules = RefitFor(Appliance.Firewall.PortForwardingRules),
				ApplianceFirewallSettings = RefitFor(Appliance.Firewall.ApplianceFirewallSettings)
			},
			StaticRoutes = RefitFor(Appliance.StaticRoutes),
			Ssids = RefitFor(Appliance.Ssids),
			TrafficShaping = new()
			{
				TrafficShaping = RefitFor(Appliance.TrafficShaping.TrafficShaping),
				CustomPerformanceClasses = RefitFor(Appliance.TrafficShaping.CustomPerformanceClasses),
				Rules = RefitFor(Appliance.TrafficShaping.Rules),
				UplinkBandwidth = RefitFor(Appliance.TrafficShaping.UplinkBandwidth),
				UplinkSelection = RefitFor(Appliance.TrafficShaping.UplinkSelection),
				VpnExclusions = RefitFor(Appliance.TrafficShaping.VpnExclusions)
			},
			Uplink = new()
			{
				Statuses = RefitFor(Appliance.Uplink.Statuses)
			},
			Uplinks = new()
			{
				UsageHistory = RefitFor(Appliance.Uplinks.UsageHistory),
				Settings = RefitFor(Appliance.Uplinks.Settings),
				StatusesOverview = RefitFor(Appliance.Uplinks.StatusesOverview)
			},
			Vlans = new()
			{
				Vlans = RefitFor(Appliance.Vlans.Vlans),
				Settings = RefitFor(Appliance.Vlans.Settings)
			},
			Vpn = new()
			{
				Bgp = RefitFor(Appliance.Vpn.Bgp),
				SiteToSiteVpn = RefitFor(Appliance.Vpn.SiteToSiteVpn),
				ThirdPartyVpnPeers = RefitFor(Appliance.Vpn.ThirdPartyVpnPeers),
				VpnFirewallRules = RefitFor(Appliance.Vpn.VpnFirewallRules),
				Stats = RefitFor(Appliance.Vpn.Stats),
				Statuses = RefitFor(Appliance.Vpn.Statuses)
			},
			WarmSpare = RefitFor(Appliance.WarmSpare)
		};

		Camera = new()
		{
			Camera = RefitFor(Camera.Camera),
			Analytics = new()
			{
				Live = RefitFor(Camera.Analytics.Live),
				Overview = RefitFor(Camera.Analytics.Overview),
				Recent = RefitFor(Camera.Analytics.Recent),
				Zones = RefitFor(Camera.Analytics.Zones)
			},
			Boundaries = RefitFor(Camera.Boundaries),
			QualityAndRetention = RefitFor(Camera.QualityAndRetention),
			Sense = new()
			{
				Sense = RefitFor(Camera.Sense.Sense)
			},
			Video = new()
			{
				Video = RefitFor(Camera.Video.Video)
			},
			VideoLink = RefitFor(Camera.VideoLink),
			WirelessProfiles = RefitFor(Camera.WirelessProfiles),
			QualityAndRetentionProfiles = RefitFor(Camera.QualityAndRetentionProfiles),
			Schedules = RefitFor(Camera.Schedules),
			Onbording = new()
			{
				Onbording = RefitFor(Camera.Onbording.Onbording)
			},
			Roles = RefitFor(Camera.Roles)
		};

		CellularGateway = new()
		{
			ConnectivityMonitoringDestinations = RefitFor(CellularGateway.ConnectivityMonitoringDestinations),
			Dhcp = RefitFor(CellularGateway.Dhcp),
			Esims = RefitFor(CellularGateway.Esims),
			Lan = RefitFor(CellularGateway.Lan),
			PortForwardingRules = RefitFor(CellularGateway.PortForwardingRules),
			SubnetPool = RefitFor(CellularGateway.SubnetPool),
			Uplink = new()
			{
				Uplink = RefitFor(CellularGateway.Uplink.Uplink),
				Statuses = RefitFor(CellularGateway.Uplink.Statuses)
			}
		};

		SecureConnect = new()
		{
			Deployments = new()
			{
				//DataCenter = RefitSecureConnectFor(SecureConnect.Deployments.DataCenter),
				NetworkDevices = RefitSecureConnectFor(SecureConnect.Deployments.NetworkDevices),
				OrganizationTunnel = RefitSecureConnectFor(SecureConnect.Deployments.OrganizationTunnel),
				//Policy = RefitSecureConnectFor(SecureConnect.Deployments.Policy)
			},
			Policies = new()
			{
				DestinationLists = RefitSecureConnectFor(SecureConnect.Policies.DestinationLists),
				Destinations = RefitSecureConnectFor(SecureConnect.Policies.Destinations)
			}
		};

		Switch = new()
		{
			AccessControlLists = RefitFor(Switch.AccessControlLists),
			AccessPolicies = RefitFor(Switch.AccessPolicies),
			AlternateManagementInterface = RefitFor(Switch.AlternateManagementInterface),
			Devices = RefitFor(Switch.Devices),
			DscpToCosMappings = RefitFor(Switch.DscpToCosMappings),
			DhcpServerPolicy = RefitFor(Switch.DhcpServerPolicy),
			ConfigTemplates = new()
			{
				Profiles = RefitFor(Switch.ConfigTemplates.Profiles)
			},
			Mtu = RefitFor(Switch.Mtu),
			LinkAggregations = RefitFor(Switch.LinkAggregations),
			Ports = RefitFor(Switch.Ports),
			PortSchedules = RefitFor(Switch.PortSchedules),
			QosRules = RefitFor(Switch.QosRules),
			Routing = new()
			{
				Interfaces = RefitFor(Switch.Routing.Interfaces),
				Multicast = RefitFor(Switch.Routing.Multicast),
				Ospf = RefitFor(Switch.Routing.Ospf),
				StaticRoutes = RefitFor(Switch.Routing.StaticRoutes)
			},
			Settings = RefitFor(Switch.Settings),
			Stacks = RefitFor(Switch.Stacks),
			StormControl = RefitFor(Switch.StormControl),
			Stp = RefitFor(Switch.Stp),
			WarmSpare = RefitFor(Switch.WarmSpare)
		};

		Wireless = new()
		{
			AirMarshal = RefitFor(Wireless.AirMarshal),
			AlternateManagementInterface = RefitFor(Wireless.AlternateManagementInterface),
			Billing = RefitFor(Wireless.Billing),
			Bluetooth = new()
			{
				Settings = RefitFor(Wireless.Bluetooth.Settings)
			},
			ChannelUtilizationHistory = RefitFor(Wireless.ChannelUtilizationHistory),
			Clients = new()
			{
				ConnectionStats = RefitFor(Wireless.Clients.ConnectionStats),
				ConnectivityEvents = RefitFor(Wireless.Clients.ConnectivityEvents),
				LatencyHistory = RefitFor(Wireless.Clients.LatencyHistory),
				LatencyStats = RefitFor(Wireless.Clients.LatencyStats)
			},
			ClientCountHistory = RefitFor(Wireless.ClientCountHistory),
			Devices = new()
			{
				ConnectionStats = RefitFor(Wireless.Devices.ConnectionStats),
				LatencyStats = RefitFor(Wireless.Devices.LatencyStats),
				OrganizationEthernetStatuses = RefitFor(Wireless.Devices.OrganizationEthernetStatuses),
				PacketLoss = RefitFor(Wireless.Devices.PacketLoss),
			},
			ConnectionStats = RefitFor(Wireless.ConnectionStats),
			EthernetPortsProfile = RefitFor(Wireless.EthernetPortsProfile),
			FailedConnections = RefitFor(Wireless.FailedConnections),
			LatencyHistory = RefitFor(Wireless.LatencyHistory),
			LatencyStats = RefitFor(Wireless.LatencyStats),
			MeshStatuses = RefitFor(Wireless.MeshStatuses),
			Radio = new()
			{
				Settings = RefitFor(Wireless.Radio.Settings)
			},
			RfProfiles = RefitFor(Wireless.RfProfiles),
			Settings = RefitFor(Wireless.Settings),
			SignalQualityHistory = RefitFor(Wireless.SignalQualityHistory),
			Status = RefitFor(Wireless.Status),
			Ssids = new()
			{
				Ssids = RefitFor(Wireless.Ssids.Ssids),
				BonjourForwarding = RefitFor(Wireless.Ssids.BonjourForwarding),
				DeviceTypeGroupPolicies = RefitFor(Wireless.Ssids.DeviceTypeGroupPolicies),
				EapOverride = RefitFor(Wireless.Ssids.EapOverride),
				Firewall = RefitFor(Wireless.Ssids.Firewall),
				HotSpot20 = RefitFor(Wireless.Ssids.HotSpot20),
				IdentityPsks = RefitFor(Wireless.Ssids.IdentityPsks),
				Schedules = RefitFor(Wireless.Ssids.Schedules),
				Splash = RefitFor(Wireless.Ssids.Splash),
				Statuses = RefitFor(Wireless.Ssids.Statuses),
				TrafficShaping = RefitFor(Wireless.Ssids.TrafficShaping),
				Vpn = RefitFor(Wireless.Ssids.Vpn)
			},
			UsageHistory = RefitFor(Wireless.UsageHistory)
		};

		Insight = new()
		{
			Applications = new()
			{
				Applications = RefitFor(Insight.Applications.Applications),
				HealthByTime = RefitFor(Insight.Applications.HealthByTime)
			},
			MonitoredMediaServers = RefitFor(Insight.MonitoredMediaServers)
		};

		Licensing = new()
		{
			Subscriptions = RefitFor(Licensing.Subscriptions)
		};

		LiveTools = new()
		{
			ArpTable = RefitFor(LiveTools.ArpTable),
			CableTest = RefitFor(LiveTools.CableTest),
			Ping = RefitFor(LiveTools.Ping),
			PingDevice = RefitFor(LiveTools.PingDevice),
			ThroughputTest = RefitFor(LiveTools.ThroughputTest),
			WakeOnLan = RefitFor(LiveTools.WakeOnLan)
		};

		Sensor = new()
		{
			Alerts = new()
			{
				Profiles = RefitFor(Sensor.Alerts.Profiles)
			},
			Readings = new()
			{
				Latest = RefitFor(Sensor.Readings.Latest),
				History = RefitFor(Sensor.Readings.History)
			},
			Relationships = RefitFor(Sensor.Relationships)
		};

		Sm = new()
		{
			ApnsCert = RefitFor(Sm.ApnsCert),
			Devices = new()
			{
				Devices = RefitFor(Sm.Devices.Devices),
				BypassActivationLockAttempts = RefitFor(Sm.Devices.BypassActivationLockAttempts),
				CellularUsageHistory = RefitFor(Sm.Devices.CellularUsageHistory),
				Certs = RefitFor(Sm.Devices.Certs),
				Connectivity = RefitFor(Sm.Devices.Connectivity),
				DesktopLogs = RefitFor(Sm.Devices.DesktopLogs),
				DeviceCommandLogs = RefitFor(Sm.Devices.DeviceCommandLogs),
				DeviceProfiles = RefitFor(Sm.Devices.DeviceProfiles),
				Fields = RefitFor(Sm.Devices.Fields),
				NetworkAdapters = RefitFor(Sm.Devices.NetworkAdapters),
				PerformanceHistory = RefitFor(Sm.Devices.PerformanceHistory),
				Restrictions = RefitFor(Sm.Devices.Restrictions),
				SecurityCenters = RefitFor(Sm.Devices.SecurityCenters),
				Softwares = RefitFor(Sm.Devices.Softwares),
				WlanLists = RefitFor(Sm.Devices.WlanLists)
			},
			Profiles = RefitFor(Sm.Profiles),
			UserAccessDevices = RefitFor(Sm.UserAccessDevices),
			TargetGroups = RefitFor(Sm.TargetGroups),
			Users = new()
			{
				Users = RefitFor(Sm.Users.Users),
				DeviceProfiles = RefitFor(Sm.Users.DeviceProfiles),
				Softwares = RefitFor(Sm.Users.Softwares)
			},
			VppAccounts = RefitFor(Sm.VppAccounts)
		};
	}

	private T RefitFor<T>(T _) =>
		typeof(T).IsInterface
			? RestService.For<T>(_coreHttpClient, _refitSettings)
			: throw new ArgumentException($"Type {typeof(T).Name} must be an interface", nameof(_));

	private T RefitSecureConnectFor<T>(T _)
	=> RestService.For<T>(_secureConnectHttpClient, _refitSettings);

	private readonly RefitSettings _refitSettings;

	/// <summary>
	/// Gets the appliance
	/// </summary>

	public ApplianceSection Appliance { get; } = new();

	/// <summary>
	/// Generate a snapshot of what the camera sees at the specified time and return a link to that image.
	/// </summary>

	public CameraSection Camera { get; } = new();

	/// <summary>
	/// Gets the cellular gateway
	/// </summary>

	public CellularGatewaySection CellularGateway { get; } = new();

	/// <summary>
	/// Return a single device
	/// </summary>

	public DevicesSection Devices { get; } = new();

	/// <summary>
	/// Gets the insight
	/// </summary>

	public InsightSection Insight { get; } = new();

	/// <summary>
	/// Gets the licensing
	/// </summary>

	public LicensingSection Licensing { get; } = new();

	/// <summary>
	/// Gets the live tools
	/// </summary>

	public LiveToolsSection LiveTools { get; } = new();

	/// <summary>
	/// Return a network
	/// </summary>

	public NetworksSection Networks { get; } = new();

	/// <summary>
	/// List the organizations that the user has privileges on
	/// </summary>

	public OrganizationsSection Organizations { get; } = new();

	/// <summary>
	/// Gets the sensor
	/// </summary>

	public SensorSection Sensor { get; } = new();

	/// <summary>
	/// Gets the sm
	/// </summary>

	public SmSection Sm { get; } = new();

	/// <summary>
	/// Gets the secure connect
	/// </summary>

	public SecureConnectSection SecureConnect { get; } = new();

	/// <summary>
	/// Gets the switch
	/// </summary>

	public SwitchSection Switch { get; } = new();

	/// <summary>
	/// Gets the wireless
	/// </summary>

	public WirelessSection Wireless { get; } = new();

	/// <summary>
	/// Used to find out whether the client has the ReadOnly option set
	/// </summary>
	public bool IsReadOnly => _options.ReadOnly;

	/// <summary>
	/// Gets the last response headers
	/// </summary>

	public HttpResponseHeaders? LastResponseHeaders { get; set; }

	/// <summary>
	/// Used to change the Options Readonly state after client is created
	/// </summary>
	public void SetReadOnly(bool readOnly)
		=> _options.ReadOnly = readOnly;

	#region IDisposable Support
	private bool _disposedValue; // To detect redundant calls

	/// <summary>
	/// Releases the unmanaged resources used by the MerakiClient and optionally releases the managed resources
	/// </summary>
	/// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources</param>
	protected virtual void Dispose(bool disposing)
	{
		if (!_disposedValue)
		{
			if (disposing)
			{
				_coreHttpClient.Dispose();
				_secureConnectHttpClient.Dispose();
				_httpClientHandler.Dispose();
			}

			_disposedValue = true;
		}
	}

	// This code added to correctly implement the disposable pattern.
	/// <summary>
	/// Dispose
	/// </summary>
	public void Dispose()
	{
		// Do not change this code. Put cleanup code in Dispose(bool disposing) above.
		Dispose(true);

		GC.SuppressFinalize(this);
	}
	#endregion
}
