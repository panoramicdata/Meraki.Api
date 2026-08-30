using Meraki.Api.Sections.General.LiveTools;
using Meraki.Api.Sections.Products.Licensing;
using Meraki.Api.Sections.SecureConnect;

namespace Meraki.Api;

/// <summary>
/// Builds the product-level API sections, one per Meraki product family.
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
	private ApplianceSection BuildApplianceSection()
		=> new()
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
			Prefixes = BuildAppliancePrefixesSection(),
			RadioSettings = RefitFor(Appliance.RadioSettings),
			RfProfiles = RefitFor(Appliance.RfProfiles),
			SdwanInternetPolices = RefitFor(Appliance.SdwanInternetPolices),
			Security = BuildApplianceSecuritySection(),
			Settings = RefitFor(Appliance.Settings),
			SingleLan = RefitFor(Appliance.SingleLan),
			Dhcp = new()
			{
				Subnets = RefitFor(Appliance.Dhcp.Subnets)
			},
			DnsLocalProfiles = RefitFor(Appliance.DnsLocalProfiles),
			Firewall = BuildApplianceFirewallSection(),
			StaticRoutes = RefitFor(Appliance.StaticRoutes),
			Ssids = RefitFor(Appliance.Ssids),
			TrafficShaping = BuildApplianceTrafficShapingSection(),
			Uplink = new()
			{
				Statuses = RefitFor(Appliance.Uplink.Statuses)
			},
			Uplinks = BuildApplianceUplinksSection(),
			Vlans = new()
			{
				Vlans = RefitFor(Appliance.Vlans.Vlans),
				Settings = RefitFor(Appliance.Vlans.Settings)
			},
			Vpn = BuildApplianceVpnSection(),
			WarmSpare = RefitFor(Appliance.WarmSpare)
		};

	private CameraSection BuildCameraSection()
		=> new()
		{
			Camera = RefitFor(Camera.Camera),
			Analytics = BuildCameraAnalyticsSection(),
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

	private CellularGatewaySection BuildCellularGatewaySection()
		=> new()
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

	private SecureConnectSection BuildSecureConnectSection()
		=> new()
		{
			Deployments = BuildSecureConnectDeploymentsSection(),
			Policies = new()
			{
				DestinationLists = RefitSecureConnectFor(SecureConnect.Policies.DestinationLists),
				Destinations = RefitSecureConnectFor(SecureConnect.Policies.Destinations)
			}
		};

	private SwitchSection BuildSwitchSection()
		=> new()
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
			Routing = BuildSwitchRoutingSection(),
			Settings = RefitFor(Switch.Settings),
			Stacks = RefitFor(Switch.Stacks),
			StormControl = RefitFor(Switch.StormControl),
			Stp = RefitFor(Switch.Stp),
			WarmSpare = RefitFor(Switch.WarmSpare)
		};

	private WirelessSection BuildWirelessSection()
		=> new()
		{
			AirMarshal = RefitFor(Wireless.AirMarshal),
			AlternateManagementInterface = RefitFor(Wireless.AlternateManagementInterface),
			Billing = RefitFor(Wireless.Billing),
			Bluetooth = new()
			{
				Settings = RefitFor(Wireless.Bluetooth.Settings)
			},
			ChannelUtilizationHistory = RefitFor(Wireless.ChannelUtilizationHistory),
			Clients = BuildWirelessClientsSection(),
			ClientCountHistory = RefitFor(Wireless.ClientCountHistory),
			Devices = BuildWirelessDevicesSection(),
			ConnectionStats = RefitFor(Wireless.ConnectionStats),
			DataRateHistory = RefitFor(Wireless.DataRateHistory),
			EthernetPortsProfile = RefitFor(Wireless.EthernetPortsProfile),
			FailedConnections = RefitFor(Wireless.FailedConnections),
			LatencyHistory = RefitFor(Wireless.LatencyHistory),
			LatencyStats = RefitFor(Wireless.LatencyStats),
			MeshStatuses = RefitFor(Wireless.MeshStatuses),
			Radio = new()
			{
				Settings = RefitFor(Wireless.Radio.Settings),
				RfHealth = RefitFor(Wireless.Radio.RfHealth)
			},
			RfProfiles = RefitFor(Wireless.RfProfiles),
			Settings = RefitFor(Wireless.Settings),
			SignalQualityHistory = RefitFor(Wireless.SignalQualityHistory),
			Status = RefitFor(Wireless.Status),
			Ssids = BuildWirelessSsidsSection(),
			UsageHistory = RefitFor(Wireless.UsageHistory)
		};

	private InsightSection BuildInsightSection()
		=> new()
		{
			Applications = new()
			{
				Applications = RefitFor(Insight.Applications.Applications),
				HealthByTime = RefitFor(Insight.Applications.HealthByTime)
			},
			MonitoredMediaServers = RefitFor(Insight.MonitoredMediaServers)
		};

	private LicensingSection BuildLicensingSection()
		=> new()
		{
			Subscriptions = new()
			{
				Subscriptions = RefitFor(Licensing.Subscriptions.Subscriptions),
				Entitlements = RefitFor(Licensing.Subscriptions.Entitlements)
			}
		};

	private LiveToolsSection BuildLiveToolsSection()
		=> new()
		{
			ArpTable = RefitFor(LiveTools.ArpTable),
			CableTest = RefitFor(LiveTools.CableTest),
			Ping = RefitFor(LiveTools.Ping),
			PingDevice = RefitFor(LiveTools.PingDevice),
			ThroughputTest = RefitFor(LiveTools.ThroughputTest),
			WakeOnLan = RefitFor(LiveTools.WakeOnLan)
		};

	private SensorSection BuildSensorSection()
		=> new()
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

	private SmSection BuildSmSection()
		=> new()
		{
			ApnsCert = RefitFor(Sm.ApnsCert),
			Devices = BuildSmDevicesSection(),
			Profiles = RefitFor(Sm.Profiles),
			UserAccessDevices = RefitFor(Sm.UserAccessDevices),
			TargetGroups = RefitFor(Sm.TargetGroups),
			Users = BuildSmUsersSection(),
			VppAccounts = RefitFor(Sm.VppAccounts)
		};
	private ApplianceFirewallSection BuildApplianceFirewallSection()
		=> new()
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
		};

	private ApplianceTrafficShapingSection BuildApplianceTrafficShapingSection()
		=> new()
		{
			TrafficShaping = RefitFor(Appliance.TrafficShaping.TrafficShaping),
			CustomPerformanceClasses = RefitFor(Appliance.TrafficShaping.CustomPerformanceClasses),
			Rules = RefitFor(Appliance.TrafficShaping.Rules),
			UplinkBandwidth = RefitFor(Appliance.TrafficShaping.UplinkBandwidth),
			UplinkSelection = RefitFor(Appliance.TrafficShaping.UplinkSelection),
			VpnExclusions = RefitFor(Appliance.TrafficShaping.VpnExclusions)
		};

	private ApplianceVpnSection BuildApplianceVpnSection()
		=> new()
		{
			Bgp = RefitFor(Appliance.Vpn.Bgp),
			SiteToSiteVpn = RefitFor(Appliance.Vpn.SiteToSiteVpn),
			ThirdPartyVpnPeers = RefitFor(Appliance.Vpn.ThirdPartyVpnPeers),
			VpnFirewallRules = RefitFor(Appliance.Vpn.VpnFirewallRules),
			Stats = RefitFor(Appliance.Vpn.Stats),
			Statuses = RefitFor(Appliance.Vpn.Statuses)
		};

	private WirelessSsidsSection BuildWirelessSsidsSection()
		=> new()
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
		};

	private SmDevicesSection BuildSmDevicesSection()
		=> new()
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
		};
	private AppliancePrefixesSection BuildAppliancePrefixesSection()
		=> new()
		{
			Delegated = new()
			{
				Statics = RefitFor(Appliance.Prefixes.Delegated.Statics)
			}
		};

	private ApplianceSecuritySection BuildApplianceSecuritySection()
		=> new()
		{
			Intrusion = RefitFor(Appliance.Security.Intrusion),
			Malware = RefitFor(Appliance.Security.Malware),
			Events = RefitFor(Appliance.Security.Events)
		};

	private ApplianceUplinksSection BuildApplianceUplinksSection()
		=> new()
		{
			UsageHistory = RefitFor(Appliance.Uplinks.UsageHistory),
			Settings = RefitFor(Appliance.Uplinks.Settings),
			StatusesOverview = RefitFor(Appliance.Uplinks.StatusesOverview)
		};

	private CameraAnalyticsSection BuildCameraAnalyticsSection()
		=> new()
		{
			Live = RefitFor(Camera.Analytics.Live),
			Overview = RefitFor(Camera.Analytics.Overview),
			Recent = RefitFor(Camera.Analytics.Recent),
			Zones = RefitFor(Camera.Analytics.Zones)
		};

	private SecureConnectDeploymentsSection BuildSecureConnectDeploymentsSection()
		=> new()
		{
			//DataCenter = RefitSecureConnectFor(SecureConnect.Deployments.DataCenter),
			NetworkDevices = RefitSecureConnectFor(SecureConnect.Deployments.NetworkDevices),
			OrganizationTunnel = RefitSecureConnectFor(SecureConnect.Deployments.OrganizationTunnel),
			//Policy = RefitSecureConnectFor(SecureConnect.Deployments.Policy)
		};

	private SwitchRoutingSection BuildSwitchRoutingSection()
		=> new()
		{
			Interfaces = RefitFor(Switch.Routing.Interfaces),
			Multicast = RefitFor(Switch.Routing.Multicast),
			Ospf = RefitFor(Switch.Routing.Ospf),
			StaticRoutes = RefitFor(Switch.Routing.StaticRoutes)
		};

	private WirelessClientsSection BuildWirelessClientsSection()
		=> new()
		{
			ConnectionStats = RefitFor(Wireless.Clients.ConnectionStats),
			ConnectivityEvents = RefitFor(Wireless.Clients.ConnectivityEvents),
			LatencyHistory = RefitFor(Wireless.Clients.LatencyHistory),
			LatencyStats = RefitFor(Wireless.Clients.LatencyStats)
		};

	private WirelessDevicesSection BuildWirelessDevicesSection()
		=> new()
		{
			ConnectionStats = RefitFor(Wireless.Devices.ConnectionStats),
			LatencyStats = RefitFor(Wireless.Devices.LatencyStats),
			OrganizationEthernetStatuses = RefitFor(Wireless.Devices.OrganizationEthernetStatuses),
			PacketLoss = RefitFor(Wireless.Devices.PacketLoss),
		};

	private SmUsersSection BuildSmUsersSection()
		=> new()
		{
			Users = RefitFor(Sm.Users.Users),
			DeviceProfiles = RefitFor(Sm.Users.DeviceProfiles),
			Softwares = RefitFor(Sm.Users.Softwares)
		};
}
#pragma warning restore S2333