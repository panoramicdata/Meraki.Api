
namespace Meraki.Api;

/// <summary>
/// Builds the network-level API sections.
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
	private NetworksSection BuildNetworksSection()
		=> new()
		{
			Networks = RefitFor(Networks.Networks),
			Alerts = BuildNetworksAlertsSection(),
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
			Alerts = BuildNetworksSensorAlertsSection(),
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
			Push = BuildOrganizationsApiPushSection()
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

	private NetworksSensorAlertsSection BuildNetworksSensorAlertsSection()
		=> new()
		{
			Current = RefitFor(Networks.Sensor.Alerts.Current),
			Overview = RefitFor(Networks.Sensor.Alerts.Overview)
		};
}
#pragma warning restore S2333
