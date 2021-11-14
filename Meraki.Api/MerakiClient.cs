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

		LinkAggregations = RefitFor(LinkAggregations)!;
		NamedTagScopes = RefitFor(NamedTagScopes)!;
		Sms = RefitFor(Sms)!;
		SplashLoginAttempts = RefitFor(SplashLoginAttempts)!;
		Ssids = RefitFor(Ssids)!;
		TrafficShaping = RefitFor(TrafficShaping)!;
		UplinkSettings = RefitFor(UplinkSettings)!;
		Vlans = RefitFor(Vlans)!;
		WebhookLogs = RefitFor(WebhookLogs)!;

		// General level sections //
		Devices = new()
		{
			Clients = RefitFor(Devices.Clients),
			Devices = RefitFor(Devices.Devices),
			LldpCdp = RefitFor(Devices.LldpCdp),
			LossAndLatencyHistory = RefitFor(Devices.LossAndLatencyHistory),
			ManagementInterface = RefitFor(Devices.ManagementInterface)
		};

		Organizations = new OrganizationsSection
		{
			Organizations = RefitFor(Organizations.Organizations),
			Admins = RefitFor(Organizations.Admins),
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
			OpenapiSpec = RefitFor(Organizations.OpenapiSpec),
			Saml = new OrganizationsSamlSection
			{
				Saml = RefitFor(Organizations.Saml.Saml),
				Idp = RefitFor(Organizations.Saml.Idp),
			},
			SamlRoles = RefitFor(Organizations.SamlRoles),
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
			Floorplans = RefitFor(Networks.Floorplans),
			GroupPolicies = RefitFor(Networks.GroupPolicies),
			Health = new()
			{
				ChannelUtilization = RefitFor(Networks.Health.ChannelUtilization)
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
			SyslogServers = RefitFor(Networks.SyslogServers),
			WebHooks = new()
			{
				HttpServers = RefitFor(Networks.WebHooks.HttpServers),
				WebhookTests = RefitFor(Networks.WebHooks.WebhookTests)
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
				Categories = RefitFor(Appliance.ContentFiltering.Categories),
			},
			Performance = RefitFor(Appliance.Performance),
			Ports = RefitFor(Appliance.Ports),
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
			StaticRoutes = RefitFor(Appliance.StaticRoutes),
			TrafficShaping = new()
			{
				TrafficShaping = RefitFor(Appliance.TrafficShaping.TrafficShaping),
				CustomPerformanceClasses = RefitFor(Appliance.TrafficShaping.CustomPerformanceClasses),
				Rules = RefitFor(Appliance.TrafficShaping.Rules),
				UplinkBandwidth = RefitFor(Appliance.TrafficShaping.UplinkBandwidth),
				UplinkSelection = RefitFor(Appliance.TrafficShaping.UplinkSelection),
			},
			Vpn = new()
			{
				Bgp = RefitFor(Appliance.Vpn.Bgp),
				SiteToSiteVpn = RefitFor(Appliance.Vpn.SiteToSiteVpn),
				ThirdPartyVpnPeers = RefitFor(Appliance.Vpn.ThirdPartyVpnPeers),
				VpnFirewallRules = RefitFor(Appliance.Vpn.VpnFirewallRules),
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
			AirMarshal = RefitFor(Wireless.AirMarshal),
			Billing = RefitFor(Wireless.Billing),
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
				LatencyStats = RefitFor(Wireless.Devices.LatencyStats)
			},
			ConnectionStats = RefitFor(Wireless.ConnectionStats),
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

		Sm = new()
		{
			TargetGroups = RefitFor(Sm.TargetGroups)
		};
	}

	private T RefitFor<T>(T _)
		=> RestService.For<T>(_httpClient, _refitSettings);

	private readonly RefitSettings _refitSettings;

	public ApplianceSection Appliance { get; } = new();

	public CameraSection Camera { get; } = new();

	public CellularGatewaySection CellularGateway { get; } = new();

	public DevicesSection Devices { get; } = new();

	public InsightSection Insight { get; } = new();

	/// <summary>
	/// Link aggregations
	/// </summary>
	public ISwitchLinkAggregations LinkAggregations { get; }

	/// <summary>
	/// Named tag scopes
	/// </summary>
	public ISmTargetGroups NamedTagScopes { get; }

	/// <summary>
	/// Networks
	/// </summary>
	public NetworksSection Networks { get; } = new();

	/// <summary>
	/// Organizations
	/// </summary>
	public OrganizationsSection Organizations { get; } = new();

	/// <summary>
	/// SMs
	/// </summary>
	public ISms Sms { get; }

	/// <summary>
	/// Splash login attempts
	/// </summary>
	public ISplashLoginAttempts SplashLoginAttempts { get; }

	public SmSection Sm { get; } = new();

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
