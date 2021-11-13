namespace Meraki.Api;

/// <summary>
/// A Meraki Dashboard API client!
/// </summary>
public partial class MerakiClient : IDisposable
{
	private readonly MerakiClientOptions _options;
	private readonly ILogger _logger;
	private readonly HttpClient _httpClient;
	private readonly AuthenticatedBackingOffHttpClientHandler _httpClientHandler;

	/// <summary>
	/// A Meraki portal client
	/// </summary>
	/// <param name="options"></param>
	/// <param name="logger"></param>
	public MerakiClient(MerakiClientOptions options, ILogger? logger = default)
	{
		_options = options;
		_logger = logger ?? NullLogger.Instance;
		_httpClientHandler = new AuthenticatedBackingOffHttpClientHandler(options ?? throw new ArgumentNullException(nameof(options)), this, _logger);
		_httpClient = new HttpClient(_httpClientHandler) { BaseAddress = new Uri($"https://{options.ApiNode ?? "api"}.meraki.com/api/v1") };
		_httpClient.Timeout = TimeSpan.FromSeconds(options.HttpClientTimeoutSeconds);
		_refitSettings = new RefitSettings
		{
			ContentSerializer = new NewtonsoftJsonContentSerializer(
			new JsonSerializerSettings
			{
				// By default nulls should not be rendered out, this will allow the receiving API to apply any defaults.
				// Use [JsonProperty(NullValueHandling = NullValueHandling.Include)] to send
				// nulls for specific properties, e.g. disassociating port schedule ids from a port
				NullValueHandling = NullValueHandling.Ignore,
#if DEBUG
				MissingMemberHandling = MissingMemberHandling.Error,
#endif
				Converters = new List<JsonConverter> { new StringEnumConverter() }
			})
		};

		ActionBatches = RefitFor(ActionBatches)!;
		Admins = RefitFor(Admins)!;
		AlertSettings = RefitFor(AlertSettings)!;
		ApiRequests = RefitFor(ApiRequests)!;
		BluetoothClients = RefitFor(BluetoothClients)!;
		CameraQualityRetentionProfiles = RefitFor(CameraQualityRetentionProfiles)!;
		Cameras = RefitFor(Cameras)!;
		ChangeLogs = RefitFor(ChangeLogs)!;
		Clients = RefitFor(Clients)!;
		ConfigurationTemplates = RefitFor(ConfigurationTemplates)!;
		ConnectivityMonitoringDestinations = RefitFor(ConnectivityMonitoringDestinations)!;
		DashboardBrandingPolicies = RefitFor(DashboardBrandingPolicies)!;
		Devices = RefitFor(Devices)!;
		Events = RefitFor(Events)!;
		Firewalls = RefitFor(Firewalls)!;
		Floorplans = RefitFor(Floorplans)!;
		LinkAggregations = RefitFor(LinkAggregations)!;
		MgConnectivityMonitoringDestinations = RefitFor(MgConnectivityMonitoringDestinations)!;
		MgDhcpSettings = RefitFor(MgDhcpSettings)!;
		MgLanSettings = RefitFor(MgLanSettings)!;
		MgPortForwardingRules = RefitFor(MgPortForwardingRules)!;
		MgSubnetPoolSettings = RefitFor(MgSubnetPoolSettings)!;
		MgUplinkSettings = RefitFor(MgUplinkSettings)!;
		MonitoredMediaServers = RefitFor(MonitoredMediaServers)!;
		MrLayer3FirewallRules = RefitFor(MrLayer3FirewallRules)!;
		MvSense = RefitFor(MvSense)!;
		NetworkAppliances = RefitFor(NetworkAppliances)!;
		NamedTagScopes = RefitFor(NamedTagScopes)!;
		NetworkGroupPolicies = RefitFor(NetworkGroupPolicies)!;
		NetworkHttpServers = RefitFor(NetworkHttpServers)!;
		NetworkMerakiAuthUsers = RefitFor(NetworkMerakiAuthUsers)!;
		NetworkMqttBrokers = RefitFor(NetworkMqttBrokers)!;
		NetworkPiiRequests = RefitFor(NetworkPiiRequests)!;
		OpenApiSpec = RefitFor(OpenApiSpec)!;
		RadioSettings = RefitFor(RadioSettings)!;
		SamlRoles = RefitFor(SamlRoles)!;
		SecurityEvents = RefitFor(SecurityEvents)!;
		Sms = RefitFor(Sms)!;
		SplashLoginAttempts = RefitFor(SplashLoginAttempts)!;
		Ssids = RefitFor(Ssids)!;
		TrafficShaping = RefitFor(TrafficShaping)!;
		UplinkSettings = RefitFor(UplinkSettings)!;
		Vlans = RefitFor(Vlans)!;
		WebhookLogs = RefitFor(WebhookLogs)!;
		WirelessHealth = RefitFor(WirelessHealth)!;
		WirelessSettings = RefitFor(WirelessSettings);

		// General level sections //
		Organizations = new OrganizationsSection
		{
			Organizations = RefitFor(Organizations.Organizations),

			ActionBatches = RefitFor(Organizations.ActionBatches),
			AdaptivePolicy = new OrganizationsAdaptivePolicySection
			{
				Acls = RefitFor(Organizations.AdaptivePolicy.Acls),
				Settings = RefitFor(Organizations.AdaptivePolicy.Settings)
			},
			ApiRequests = RefitFor(Organizations.ApiRequests),
			BrandingPolicies = new()
			{
				BrandingPolicies = RefitFor(Organizations.BrandingPolicies.BrandingPolicies),
				Priorities = RefitFor(Organizations.BrandingPolicies.Priorities)
			},
			ConfigurationChanges = RefitFor(Organizations.ConfigurationChanges),
			Devices = RefitFor(Organizations.Devices),
			InventoryDevices = RefitFor(Organizations.InventoryDevices),
			Licenses = RefitFor(Organizations.Licenses),
			LoginSecurity = RefitFor(Organizations.LoginSecurity),
			Networks = RefitFor(Organizations.Networks),
			Saml = new OrganizationsSamlSection
			{
				Saml = RefitFor(Organizations.Saml.Saml),
				Idp = RefitFor(Organizations.Saml.Idp),
			},
			Snmp = RefitFor(Organizations.Snmp),
			Webhooks = new()
			{
				AlertTypes = RefitFor(Organizations.Webhooks.AlertTypes)
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
			Floorplans = RefitFor(Networks.Floorplans)
		};

		// Product level sections //
		Appliance = new()
		{
			ConnectivityMonitoringDestinations = RefitFor(Appliance.ConnectivityMonitoringDestinations),
			Performance = RefitFor(Appliance.Performance),
			Security = new()
			{
				Intrusion = RefitFor(Appliance.Security.Intrusion)
			},
			Dhpc = new()
			{
				Subnets = RefitFor(Appliance.Dhpc.Subnets)
			},
			Firewall = new()
			{
				CellularFirewallRules = RefitFor(Appliance.Firewall.CellularFirewallRules),
				FirewalledServices = RefitFor(Appliance.Firewall.FirewalledServices),
				InboundFirewallRules = RefitFor(Appliance.Firewall.InboundFirewallRules),
				L3FirewallRules = RefitFor(Appliance.Firewall.L3FirewallRules),
				L7FirewallRules = RefitFor(Appliance.Firewall.L7FirewallRules),
				OneToManyNatRules = RefitFor(Appliance.Firewall.OneToManyNatRules),
				OneToOneNatRules = RefitFor(Appliance.Firewall.OneToOneNatRules),
				PortForwardingRules = RefitFor(Appliance.Firewall.PortForwardingRules)
			},
			Vpn = new()
			{
				Bgp = RefitFor(Appliance.Vpn.Bgp),
				SiteToSiteVpn = RefitFor(Appliance.Vpn.SiteToSiteVpn),
				ThirdPartyVpnPeers = RefitFor(Appliance.Vpn.ThirdPartyVpnPeers),
				VpnFirewallRules = RefitFor(Appliance.Vpn.VpnFirewallRules),
			}
		};

		Camera = new()
		{
			QualityAndRetention = RefitFor(Camera.QualityAndRetention)
		};

		CellularGateway = new()
		{
			ConnectivityMonitoringDestinations = RefitFor(CellularGateway.ConnectivityMonitoringDestinations),
			Dhcp = RefitFor(CellularGateway.Dhcp),
			Lan = RefitFor(CellularGateway.Lan),
			PortForwardingRules = RefitFor(CellularGateway.PortForwardingRules),
			SubnetPool = RefitFor(CellularGateway.SubnetPool),
			Uplink = RefitFor(CellularGateway.Uplink)
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
			WarmSpare = RefitFor(Switch.WarmSpare),
		};

		Wireless = new()
		{
			Billing = RefitFor(Wireless.Billing),
			Clients = new()
			{
				ConnectionStats = RefitFor(Wireless.Clients.ConnectionStats),
				ConnectivityEvents = RefitFor(Wireless.Clients.ConnectivityEvents),
				LatencyHistory = RefitFor(Wireless.Clients.LatencyHistory),
				LatencyStats = RefitFor(Wireless.Clients.LatencyStats)
			},
			ClientCountHistory = RefitFor(Wireless.ClientCountHistory),
			Ssids = new()
			{
				Firewall = RefitFor(Wireless.Ssids.Firewall)
			}
		};

		Insight = new()
		{
			Applications = new()
			{
				Applications = RefitFor(Insight.Applications.Applications),
				HealthByTime = RefitFor(Insight.Applications.HealthByTime)
			}
		};
	}

	private T RefitFor<T>(T _)
		=> RestService.For<T>(_httpClient, _refitSettings);

	private readonly RefitSettings _refitSettings;

	public ApplianceSection Appliance { get; } = new();

	/// <summary>
	/// Action batches
	/// </summary>
	public IOrganizationsActionBatches ActionBatches { get; }

	/// <summary>
	/// Admins
	/// </summary>
	public IOrganizationsAdmins Admins { get; }

	/// <summary>
	/// Alert settings
	/// </summary>
	public INetworksAlertSettings AlertSettings { get; }

	/// <summary>
	/// API Usages
	/// </summary>
	public IOrganizationsApiRequests ApiRequests { get; }

	/// <summary>
	/// Bluetooth clients
	/// </summary>
	public INetworksBluetoothClients BluetoothClients { get; }

	public CameraSection Camera { get; } = new();

	public CellularGatewaySection CellularGateway { get; } = new();

	/// <summary>
	/// Camera quality retention policies
	/// </summary>
	public ICameraQualityAndRetention CameraQualityRetentionProfiles { get; }

	/// <summary>
	/// Cameras
	/// </summary>
	public ICameras Cameras { get; }

	/// <summary>
	/// Change logs
	/// </summary>
	public IOrganizationsConfigurationChanges ChangeLogs { get; }

	/// <summary>
	/// Clients
	/// </summary>
	public IClients Clients { get; }

	/// <summary>
	/// Configuration templates
	/// </summary>
	public IConfigurationTemplates ConfigurationTemplates { get; }

	/// <summary>
	/// Connectivity monitoring destinations
	/// </summary>
	public IApplianceConnectivityMonitoringDestinations ConnectivityMonitoringDestinations { get; }

	/// <summary>
	/// Dashboard branding policies
	/// </summary>
	public IDashboardBrandingPolicies DashboardBrandingPolicies { get; }

	/// <summary>
	/// Devices
	/// </summary>
	public IDevices Devices { get; }

	/// <summary>
	/// Events
	/// </summary>
	public IEvents Events { get; }

	/// <summary>
	/// Firewalled services
	/// </summary>
	public IFirewalls Firewalls { get; }

	/// <summary>
	/// Floor plans
	/// </summary>
	public INetworksFloorplans Floorplans { get; }

	public InsightSection Insight { get; } = new();

	/// <summary>
	/// HTTP servers
	/// </summary>
	public INetworkHttpServers NetworkHttpServers { get; }

	/// <summary>
	/// Link aggregations
	/// </summary>
	public ISwitchLinkAggregations LinkAggregations { get; }

	/// <summary>
	/// Meraki auth users
	/// </summary>
	public INetworkMerakiAuthUsers NetworkMerakiAuthUsers { get; }

	/// <summary>
	/// MQTT brokers
	/// </summary>
	public INetworkMqttBrokers NetworkMqttBrokers { get; }

	/// <summary>
	/// MG connectivity monitoring destinations
	/// </summary>
	public IMgConnectivityMonitoringDestinations MgConnectivityMonitoringDestinations { get; }

	/// <summary>
	/// MG DHCP settings
	/// </summary>
	public ICellularGatewayDhcp MgDhcpSettings { get; }

	/// <summary>
	/// MG LAN settings
	/// </summary>
	public ICellularGatewayLan MgLanSettings { get; }

	/// <summary>
	/// MG port forwarding rules
	/// </summary>
	public ICellularGatewayPortForwardingRules MgPortForwardingRules { get; }

	/// <summary>
	/// MG subnet pool settings
	/// </summary>
	public ICellularGatewaySubnetPool MgSubnetPoolSettings { get; }

	/// <summary>
	/// MG uplink settings
	/// </summary>
	public ICellularGatewayUplink MgUplinkSettings { get; }

	/// <summary>
	/// Monitored media servers
	/// </summary>
	public IInsightMonitoredMediaServers MonitoredMediaServers { get; }

	/// <summary>
	/// MR layer 3 firewall rules
	/// </summary>
	public IMrLayer3FirewallRules MrLayer3FirewallRules { get; }

	/// <summary>
	/// MV sense
	/// </summary>
	public IMvSense MvSense { get; }

	/// <summary>
	/// MX static routes
	/// </summary>
	public INetworkAppliances NetworkAppliances { get; }

	/// <summary>
	/// Named tag scopes
	/// </summary>
	public INamedTagScopes NamedTagScopes { get; }

	/// <summary>
	/// Networks
	/// </summary>
	public NetworksSection Networks { get; } = new();

	/// <summary>
	/// Group policies
	/// </summary>
	public INetworkGroupPolicies NetworkGroupPolicies { get; }

	/// <summary>
	/// Open API spec
	/// </summary>
	public IOpenApiSpec OpenApiSpec { get; }

	/// <summary>
	/// Organizations
	/// </summary>
	public OrganizationsSection Organizations { get; } = new();

	/// <summary>
	/// PIIs
	/// </summary>
	public INetworkPiiRequests NetworkPiiRequests { get; }

	/// <summary>
	/// Radio settings
	/// </summary>
	public IRadioSettings RadioSettings { get; }

	/// <summary>
	/// SAML roles
	/// </summary>
	public ISamlRoles SamlRoles { get; }

	/// <summary>
	/// Security events
	/// </summary>
	public ISecurityEvents SecurityEvents { get; }

	/// <summary>
	/// SMs
	/// </summary>
	public ISms Sms { get; }

	/// <summary>
	/// Splash login attempts
	/// </summary>
	public ISplashLoginAttempts SplashLoginAttempts { get; }

	/// <summary>
	/// SSIDs
	/// </summary>
	public ISsids Ssids { get; }

	/// <summary>
	/// Switch
	/// </summary>
	public SwitchSection Switch { get; } = new();

	/// <summary>
	/// Traffic shaping
	/// </summary>
	public ITrafficShaping TrafficShaping { get; }

	/// <summary>
	/// Uplink settings
	/// </summary>
	public IUplink UplinkSettings { get; }

	/// <summary>
	/// VLANs
	/// </summary>
	public IVlans Vlans { get; }

	/// <summary>
	/// Webhook logs
	/// </summary>
	public IWebhookLogs WebhookLogs { get; }

	public WirelessSection Wireless { get; } = new();

	/// <summary>
	/// Wireless health
	/// </summary>
	public IWirelessHealth WirelessHealth { get; }

	/// <summary>
	/// Wireless settings
	/// </summary>
	public IWirelessSettings WirelessSettings { get; } = null!;

	/// <summary>
	/// Used to find out whether the client has the ReadOnly option set
	/// </summary>
	public bool IsReadOnly => _options.ReadOnly;

	public HttpResponseHeaders? LastResponseHeaders { get; set; }

	/// <summary>
	/// Used to change the Options Readonly state after client is created
	/// </summary>
	public void SetReadOnly(bool readOnly) => _options.ReadOnly = readOnly;

	#region IDisposable Support
	private bool _disposedValue; // To detect redundant calls

	protected virtual void Dispose(bool disposing)
	{
		if (!_disposedValue)
		{
			if (disposing)
			{
				_logger.LogDebug(Resources.Disposing);
				_httpClient.Dispose();
				_httpClientHandler.Dispose();
				_logger.LogDebug(Resources.Disposed);
			}

			_disposedValue = true;
		}
	}

	// This code added to correctly implement the disposable pattern.
	public void Dispose()
	{
		// Do not change this code. Put cleanup code in Dispose(bool disposing) above.
		Dispose(true);

		GC.SuppressFinalize(this);
	}
	#endregion
}
