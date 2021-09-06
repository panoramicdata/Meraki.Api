using Meraki.Api.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Newtonsoft.Json;
using Refit;
using System;
using System.Net.Http;

namespace Meraki.Api
{
	/// <summary>
	/// A Meraki Dashboard API client
	/// </summary>
	public class MerakiClient : IDisposable
	{
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
			_logger = logger ?? NullLogger.Instance;
			_httpClientHandler = new AuthenticatedBackingOffHttpClientHandler(options ?? throw new ArgumentNullException(nameof(options)), _logger);
			_httpClient = new HttpClient(_httpClientHandler) { BaseAddress = new Uri($"https://{options.ApiNode ?? "api"}.meraki.com/api/v1") };
			_httpClient.Timeout = TimeSpan.FromSeconds(options.HttpClientTimeoutSeconds);
			var refitSettings = new RefitSettings
			{
				ContentSerializer = new NewtonsoftJsonContentSerializer(
				new JsonSerializerSettings
				{
					// By default nulls should not be rendered out, this will allow the receiving API to apply any defaults.
					// Use [JsonProperty(NullValueHandling = NullValueHandling.Include)] to send
					// nulls for specific properties, i.e. disassociating port schedule ids from a port
					NullValueHandling = NullValueHandling.Ignore
				})
			};

			ActionBatches = RestService.For<IActionBatches>(_httpClient, refitSettings);
			Admins = RestService.For<IAdmins>(_httpClient, refitSettings);
			AlertSettings = RestService.For<IAlertSettings>(_httpClient, refitSettings);
			ApiRequests = RestService.For<IApiRequests>(_httpClient, refitSettings);
			BluetoothClients = RestService.For<IBluetoothClients>(_httpClient, refitSettings);
			BluetoothSettings = RestService.For<IBluetoothSettings>(_httpClient, refitSettings);
			CameraQualityRetentionProfiles = RestService.For<ICameraQualityRetentionProfiles>(_httpClient, refitSettings);
			Cameras = RestService.For<ICameras>(_httpClient, refitSettings);
			ChangeLogs = RestService.For<IChangeLogs>(_httpClient, refitSettings);
			Clients = RestService.For<IClients>(_httpClient, refitSettings);
			ConfigurationTemplates = RestService.For<IConfigurationTemplates>(_httpClient, refitSettings);
			ConnectivityMonitoringDestinations = RestService.For<IConnectivityMonitoringDestinations>(_httpClient, refitSettings);
			ContentFilteringCategories = RestService.For<IContentFilteringCategories>(_httpClient, refitSettings);
			ContentFilteringRules = RestService.For<IContentFilteringRules>(_httpClient, refitSettings);
			DashboardBrandingPolicies = RestService.For<IDashboardBrandingPolicies>(_httpClient, refitSettings);
			Devices = RestService.For<IDevices>(_httpClient, refitSettings);
			Events = RestService.For<IEvents>(_httpClient, refitSettings);
			FirewalledServices = RestService.For<IFirewalledServices>(_httpClient, refitSettings);
			Floorplans = RestService.For<IFloorplans>(_httpClient, refitSettings);
			GroupPolicies = RestService.For<IGroupPolicies>(_httpClient, refitSettings);
			HttpServers = RestService.For<IHttpServers>(_httpClient, refitSettings);
			IntrusionSettings = RestService.For<IIntrusionSettings>(_httpClient, refitSettings);
			Licenses = RestService.For<ILicenses>(_httpClient, refitSettings);
			LinkAggregations = RestService.For<ILinkAggregations>(_httpClient, refitSettings);
			MalwareSettings = RestService.For<IMalwareSettings>(_httpClient, refitSettings);
			ManagementInterfaceSettings = RestService.For<IManagementInterfaceSettings>(_httpClient, refitSettings);
			MerakiAuthUsers = RestService.For<IMerakiAuthUsers>(_httpClient, refitSettings);
			MgConnectivityMonitoringDestinations = RestService.For<IMgConnectivityMonitoringDestinations>(_httpClient, refitSettings);
			MgDhcpSettings = RestService.For<IMgDhcpSettings>(_httpClient, refitSettings);
			MgLanSettings = RestService.For<IMgLanSettings>(_httpClient, refitSettings);
			MgPortForwardingRules = RestService.For<IMgPortForwardingRules>(_httpClient, refitSettings);
			MgSubnetPoolSettings = RestService.For<IMgSubnetPoolSettings>(_httpClient, refitSettings);
			MgUplinkSettings = RestService.For<IMgUplinkSettings>(_httpClient, refitSettings);
			MonitoredMediaServers = RestService.For<IMonitoredMediaServers>(_httpClient, refitSettings);
			MrLayer3FirewallRules = RestService.For<IMrLayer3FirewallRules>(_httpClient, refitSettings);
			MvSense = RestService.For<IMvSense>(_httpClient, refitSettings);
			MxCellularFirewallRules = RestService.For<IMxCellularFirewallRules>(_httpClient, refitSettings);
			MxInboundFirewallRules = RestService.For<IMxInboundFirewallRules>(_httpClient, refitSettings);
			MxLayer3FirewallRules = RestService.For<IMxLayer3FirewallRules>(_httpClient, refitSettings);
			MxLayer7ApplicationCategories = RestService.For<IMxLayer7ApplicationCategories>(_httpClient, refitSettings);
			MxLayer7FirewallRules = RestService.For<IMxLayer7FirewallRules>(_httpClient, refitSettings);
			MxOneToManyNatRules = RestService.For<IMxOneToManyNatRules>(_httpClient, refitSettings);
			MxOneToOneNatRules = RestService.For<IMxOneToOneNatRules>(_httpClient, refitSettings);
			MxPortForwardingRules = RestService.For<IMxPortForwardingRules>(_httpClient, refitSettings);
			MxStaticRoutes = RestService.For<IMxStaticRoutes>(_httpClient, refitSettings);
			MxVlanPorts = RestService.For<IMxVlanPorts>(_httpClient, refitSettings);
			MxVpnFirewalls = RestService.For<IMxVpnFirewallRules>(_httpClient, refitSettings);
			MxWarmSpareSettings = RestService.For<IMxWarmSpareSettings>(_httpClient, refitSettings);
			NamedTagScopes = RestService.For<INamedTagScopes>(_httpClient, refitSettings);
			NetFlowSettings = RestService.For<INetFlowSettings>(_httpClient, refitSettings);
			Networks = RestService.For<INetworks>(_httpClient, refitSettings);
			OpenApiSpec = RestService.For<IOpenApiSpec>(_httpClient, refitSettings);
			Organizations = RestService.For<IOrganizations>(_httpClient, refitSettings);
			Piis = RestService.For<IPiis>(_httpClient, refitSettings);
			RadioSettings = RestService.For<IRadioSettings>(_httpClient, refitSettings);
			SamlRoles = RestService.For<ISamlRoles>(_httpClient, refitSettings);
			SecurityEvents = RestService.For<ISecurityEvents>(_httpClient, refitSettings);
			Sms = RestService.For<ISms>(_httpClient, refitSettings);
			SnmpSettings = RestService.For<ISnmpSettings>(_httpClient, refitSettings);
			SplashSettings = RestService.For<ISplashSettings>(_httpClient, refitSettings);
			SplashLoginAttempts = RestService.For<ISplashLoginAttempts>(_httpClient, refitSettings);
			Ssids = RestService.For<ISsids>(_httpClient, refitSettings);
			SwitchAcls = RestService.For<ISwitchAcls>(_httpClient, refitSettings);
			SwitchPorts = RestService.For<ISwitchPorts>(_httpClient, refitSettings);
			SwitchPortSchedules = RestService.For<ISwitchPortSchedules>(_httpClient, refitSettings);
			SwitchProfiles = RestService.For<ISwitchProfiles>(_httpClient, refitSettings);
			SwitchSettings = RestService.For<ISwitchSettings>(_httpClient, refitSettings);
			SwitchStacks = RestService.For<ISwitchStacks>(_httpClient, refitSettings);
			SyslogServers = RestService.For<ISyslogServers>(_httpClient, refitSettings);
			TrafficAnalysisSettings = RestService.For<ITrafficAnalysisSettings>(_httpClient, refitSettings);
			TrafficShaping = RestService.For<ITrafficShaping>(_httpClient, refitSettings);
			UplinkSettings = RestService.For<IUplink>(_httpClient, refitSettings);
			Vlans = RestService.For<IVlans>(_httpClient, refitSettings);
			WebhookLogs = RestService.For<IWebhookLogs>(_httpClient, refitSettings);
			WirelessHealth = RestService.For<IWirelessHealth>(_httpClient, refitSettings);
			WirelessSettings = RestService.For<IWirelessSettings>(_httpClient, refitSettings);
		}

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
		/// Bluetooth settings
		/// </summary>
		public IBluetoothSettings BluetoothSettings { get; }

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
		/// Group policies
		/// </summary>
		public IGroupPolicies GroupPolicies { get; }

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
		/// Management interface settings
		/// </summary>
		public IManagementInterfaceSettings ManagementInterfaceSettings { get; }

		/// <summary>
		/// Meraki auth users
		/// </summary>
		public IMerakiAuthUsers MerakiAuthUsers { get; }

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
		/// NetFlow settings
		/// </summary>
		public INetFlowSettings NetFlowSettings { get; }

		/// <summary>
		/// Networks
		/// </summary>
		public INetworks Networks { get; }

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
		public IPiis Piis { get; }

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
