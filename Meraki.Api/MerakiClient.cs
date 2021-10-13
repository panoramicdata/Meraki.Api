using Meraki.Api.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Meraki.Api
{
	/// <summary>
	/// A Meraki Dashboard API client
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
					// nulls for specific properties, i.e. disassociating port schedule ids from a port
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
			Wireless = RefitFor(Wireless)!;
			CameraQualityRetentionProfiles = RefitFor(CameraQualityRetentionProfiles)!;
			Cameras = RefitFor(Cameras)!;
			ChangeLogs = RefitFor(ChangeLogs)!;
			Clients = RefitFor(Clients)!;
			ConfigurationTemplates = RefitFor(ConfigurationTemplates)!;
			ConnectivityMonitoringDestinations = RefitFor(ConnectivityMonitoringDestinations)!;
			ContentFilteringCategories = RefitFor(ContentFilteringCategories)!;
			ContentFilteringRules = RefitFor(ContentFilteringRules)!;
			DashboardBrandingPolicies = RefitFor(DashboardBrandingPolicies)!;
			Devices = RefitFor(Devices)!;
			Events = RefitFor(Events)!;
			FirewalledServices = RefitFor(FirewalledServices)!;
			Floorplans = RefitFor(Floorplans)!;
			HttpServers = RefitFor(HttpServers)!;
			IntrusionSettings = RefitFor(IntrusionSettings)!;
			Licenses = RefitFor(Licenses)!;
			LinkAggregations = RefitFor(LinkAggregations)!;
			MalwareSettings = RefitFor(MalwareSettings)!;
			MgConnectivityMonitoringDestinations = RefitFor(MgConnectivityMonitoringDestinations)!;
			MgDhcpSettings = RefitFor(MgDhcpSettings)!;
			MgLanSettings = RefitFor(MgLanSettings)!;
			MgPortForwardingRules = RefitFor(MgPortForwardingRules)!;
			MgSubnetPoolSettings = RefitFor(MgSubnetPoolSettings)!;
			MgUplinkSettings = RefitFor(MgUplinkSettings)!;
			MonitoredMediaServers = RefitFor(MonitoredMediaServers)!;
			MrLayer3FirewallRules = RefitFor(MrLayer3FirewallRules)!;
			MvSense = RefitFor(MvSense)!;
			MxCellularFirewallRules = RefitFor(MxCellularFirewallRules)!;
			MxInboundFirewallRules = RefitFor(MxInboundFirewallRules)!;
			MxLayer3FirewallRules = RefitFor(MxLayer3FirewallRules)!;
			MxLayer7ApplicationCategories = RefitFor(MxLayer7ApplicationCategories)!;
			MxLayer7FirewallRules = RefitFor(MxLayer7FirewallRules)!;
			MxOneToManyNatRules = RefitFor(MxOneToManyNatRules)!;
			MxOneToOneNatRules = RefitFor(MxOneToOneNatRules)!;
			MxPortForwardingRules = RefitFor(MxPortForwardingRules)!;
			MxStaticRoutes = RefitFor(MxStaticRoutes)!;
			MxVlanPorts = RefitFor(MxVlanPorts)!;
			MxVpnFirewalls = RefitFor(MxVpnFirewalls)!;
			MxWarmSpareSettings = RefitFor(MxWarmSpareSettings)!;
			NamedTagScopes = RefitFor(NamedTagScopes)!;
			Networks = RefitFor(Networks)!;
			NetworkGroupPolicies = RefitFor(NetworkGroupPolicies)!;
			NetworkMerakiAuthUsers = RefitFor(NetworkMerakiAuthUsers)!;
			NetworkMqttBrokers = RefitFor(NetworkMqttBrokers)!;
			NetworkPiiRequests = RefitFor(NetworkPiiRequests)!;
			OpenApiSpec = RefitFor(OpenApiSpec)!;
			Organizations = RefitFor(Organizations)!;
			RadioSettings = RefitFor(RadioSettings)!;
			SamlRoles = RefitFor(SamlRoles)!;
			SecurityEvents = RefitFor(SecurityEvents)!;
			Sms = RefitFor(Sms)!;
			SnmpSettings = RefitFor(SnmpSettings)!;
			SplashSettings = RefitFor(SplashSettings)!;
			SplashLoginAttempts = RefitFor(SplashLoginAttempts)!;
			Ssids = RefitFor(Ssids)!;
			SwitchAcls = RefitFor(SwitchAcls)!;
			SwitchPorts = RefitFor(SwitchPorts)!;
			SwitchPortSchedules = RefitFor(SwitchPortSchedules)!;
			SwitchProfiles = RefitFor(SwitchProfiles)!;
			SwitchSettings = RefitFor(SwitchSettings)!;
			SwitchStacks = RefitFor(SwitchStacks)!;
			SyslogServers = RefitFor(SyslogServers)!;
			TrafficAnalysisSettings = RefitFor(TrafficAnalysisSettings)!;
			TrafficShaping = RefitFor(TrafficShaping)!;
			UplinkSettings = RefitFor(UplinkSettings)!;
			Vlans = RefitFor(Vlans)!;
			WebhookLogs = RefitFor(WebhookLogs)!;
			WirelessHealth = RefitFor(WirelessHealth)!;
			WirelessSettings = RefitFor(WirelessSettings)!;
		}

		private T RefitFor<T>(T _)
			=> RestService.For<T>(_httpClient, _refitSettings);

		private readonly RefitSettings _refitSettings;

		/// <summary>
		/// Action batches
		/// </summary>
		public IActionBatches ActionBatches { get; }

		/// <summary>
		/// Admins
		/// </summary>
		public IAdmins Admins { get; }

		/// <summary>
		/// Alert settings
		/// </summary>
		public IAlertSettings AlertSettings { get; }

		/// <summary>
		/// API Usages
		/// </summary>
		public IApiRequests ApiRequests { get; }

		/// <summary>
		/// Bluetooth clients
		/// </summary>
		public IBluetoothClients BluetoothClients { get; }

		/// <summary>
		/// Wireless devices/networks
		/// </summary>
		public IWireless Wireless { get; }

		/// <summary>
		/// Camera quality retention policies
		/// </summary>
		public ICameraQualityRetentionProfiles CameraQualityRetentionProfiles { get; }

		/// <summary>
		/// Cameras
		/// </summary>
		public ICameras Cameras { get; }

		/// <summary>
		/// Change logs
		/// </summary>
		public IChangeLogs ChangeLogs { get; }

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
		public IConnectivityMonitoringDestinations ConnectivityMonitoringDestinations { get; }

		/// <summary>
		/// Content filtering categories
		/// </summary>
		public IContentFilteringCategories ContentFilteringCategories { get; }

		/// <summary>
		/// Content filtering rules
		/// </summary>
		public IContentFilteringRules ContentFilteringRules { get; }

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
		public IFirewalledServices FirewalledServices { get; }

		/// <summary>
		/// Floor plans
		/// </summary>
		public IFloorplans Floorplans { get; }

		/// <summary>
		/// HTTP servers
		/// </summary>
		public IHttpServers HttpServers { get; }

		/// <summary>
		/// Intrusions settings
		/// </summary>
		public IIntrusionSettings IntrusionSettings { get; }

		/// <summary>
		/// Licenses
		/// </summary>
		public ILicenses Licenses { get; }

		/// <summary>
		/// Link aggregations
		/// </summary>
		public ILinkAggregations LinkAggregations { get; }

		/// <summary>
		/// Malware settings
		/// </summary>
		public IMalwareSettings MalwareSettings { get; }

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
		public IMgDhcpSettings MgDhcpSettings { get; }

		/// <summary>
		/// MG LAN settings
		/// </summary>
		public IMgLanSettings MgLanSettings { get; }

		/// <summary>
		/// MG port forwarding rules
		/// </summary>
		public IMgPortForwardingRules MgPortForwardingRules { get; }

		/// <summary>
		/// MG subnet pool settings
		/// </summary>
		public IMgSubnetPoolSettings MgSubnetPoolSettings { get; }

		/// <summary>
		/// MG uplink settings
		/// </summary>
		public IMgUplinkSettings MgUplinkSettings { get; }

		/// <summary>
		/// Monitored media servers
		/// </summary>
		public IMonitoredMediaServers MonitoredMediaServers { get; }

		/// <summary>
		/// MR layer 3 firewall rules
		/// </summary>
		public IMrLayer3FirewallRules MrLayer3FirewallRules { get; }

		/// <summary>
		/// MV sense
		/// </summary>
		public IMvSense MvSense { get; }

		/// <summary>
		/// MX cellular firewall rules
		/// </summary>
		public IMxCellularFirewallRules MxCellularFirewallRules { get; }

		/// <summary>
		/// MX inbound firewall rules
		/// </summary>
		public IMxInboundFirewallRules MxInboundFirewallRules { get; }

		/// <summary>
		/// MX layer 3 firewall rules
		/// </summary>
		public IMxLayer3FirewallRules MxLayer3FirewallRules { get; }

		/// <summary>
		/// MX layer 7 application categories
		/// </summary>
		public IMxLayer7ApplicationCategories MxLayer7ApplicationCategories { get; }

		/// <summary>
		/// MX layer 7 firewall rules
		/// </summary>
		public IMxLayer7FirewallRules MxLayer7FirewallRules { get; }

		/// <summary>
		/// MX one-to-many NAT rules
		/// </summary>
		public IMxOneToManyNatRules MxOneToManyNatRules { get; }

		/// <summary>
		/// MX one-to-one NAT rules
		/// </summary>
		public IMxOneToOneNatRules MxOneToOneNatRules { get; }

		/// <summary>
		/// MX port forwarding rules
		/// </summary>
		public IMxPortForwardingRules MxPortForwardingRules { get; }

		/// <summary>
		/// MX static routes
		/// </summary>
		public IMxStaticRoutes MxStaticRoutes { get; }

		/// <summary>
		/// MX VLAN ports
		/// </summary>
		public IMxVlanPorts MxVlanPorts { get; }

		/// <summary>
		/// MX VPN firewall rules
		/// </summary>
		public IMxVpnFirewallRules MxVpnFirewalls { get; }

		/// <summary>
		/// MX warm spare settings
		/// </summary>
		public IMxWarmSpareSettings MxWarmSpareSettings { get; }

		/// <summary>
		/// Named tag scopes
		/// </summary>
		public INamedTagScopes NamedTagScopes { get; }

		/// <summary>
		/// Networks
		/// </summary>
		public INetworks Networks { get; }

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
		public IOrganizations Organizations { get; }

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
		/// SNMP settings
		/// </summary>
		public ISnmpSettings SnmpSettings { get; }

		/// <summary>
		/// Splash login attempts
		/// </summary>
		public ISplashLoginAttempts SplashLoginAttempts { get; }

		/// <summary>
		/// Splash settings
		/// </summary>
		public ISplashSettings SplashSettings { get; }

		/// <summary>
		/// SSIDs
		/// </summary>
		public ISsids Ssids { get; }

		/// <summary>
		/// Switch ACLs
		/// </summary>
		public ISwitchAcls SwitchAcls { get; }

		/// <summary>
		/// Switch ports
		/// </summary>
		public ISwitchPorts SwitchPorts { get; }

		/// <summary>
		/// Switch port schedules
		/// </summary>
		public ISwitchPortSchedules SwitchPortSchedules { get; }

		/// <summary>
		/// Switch profiles
		/// </summary>
		public ISwitchProfiles SwitchProfiles { get; }

		/// <summary>
		/// Switch settings
		/// </summary>
		public ISwitchSettings SwitchSettings { get; }

		/// <summary>
		/// Switch stacks
		/// </summary>
		public ISwitchStacks SwitchStacks { get; }

		/// <summary>
		/// Syslog servers
		/// </summary>
		public ISyslogServers SyslogServers { get; }

		/// <summary>
		/// Traffic analysis settings
		/// </summary>
		public ITrafficAnalysisSettings TrafficAnalysisSettings { get; }

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

		/// <summary>
		/// Wireless health
		/// </summary>
		public IWirelessHealth WirelessHealth { get; }

		/// <summary>
		/// Wireless settings
		/// </summary>
		public IWirelessSettings WirelessSettings { get; }

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
}
