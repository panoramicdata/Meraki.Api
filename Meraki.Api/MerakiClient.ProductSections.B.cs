using Meraki.Api.Sections.General.LiveTools;
using Meraki.Api.Sections.Products.Licensing;
using Meraki.Api.Sections.SecureConnect;

namespace Meraki.Api;

// Codacy analyses each file on its own, so it reports 'partial' as gratuitous (S2333) and the static-only parts as S1118. The other parts live in sibling files.
#pragma warning disable S2333, S1118
public partial class MerakiClient
{
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
			AclHitCount = RefitFor(LiveTools.AclHitCount),
			ArpTable = RefitFor(LiveTools.ArpTable),
			CableTest = RefitFor(LiveTools.CableTest),
			CyclePort = RefitFor(LiveTools.CyclePort),
			DhcpLeases = RefitFor(LiveTools.DhcpLeases),
			Leds = RefitFor(LiveTools.Leds),
			MacTable = RefitFor(LiveTools.MacTable),
			MulticastRouting = RefitFor(LiveTools.MulticastRouting),
			OspfNeighbors = RefitFor(LiveTools.OspfNeighbors),
			Ping = RefitFor(LiveTools.Ping),
			PingDevice = RefitFor(LiveTools.PingDevice),
			RoutingTable = RefitFor(LiveTools.RoutingTable),
			SpeedTest = RefitFor(LiveTools.SpeedTest),
			ThroughputTest = RefitFor(LiveTools.ThroughputTest),
			TraceRoute = RefitFor(LiveTools.TraceRoute),
			WakeOnLan = RefitFor(LiveTools.WakeOnLan)
		};

	private SensorSection BuildSensorSection()
		=> new()
		{
			Alerts = new()
			{
				Profiles = RefitFor(Sensor.Alerts.Profiles)
			},
			Gateways = new()
			{
				ConnectionsLatest = RefitFor(Sensor.Gateways.ConnectionsLatest)
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
}
