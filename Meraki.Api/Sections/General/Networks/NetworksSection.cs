namespace Meraki.Api.Sections.General.Networks;

public partial class NetworksSection
{
	[RefitPromoteCalls]
	internal INetworks Networks { get; set; } = null!;
	public NetworksAlertsSection Alerts { get; internal set; } = new();
	public INetworksBluetoothClients BluetoothClients { get; internal set; } = null!;
	public NetworksClientsSection Clients { get; internal set; } = new();
	public INetworksDevices Devices { get; internal set; } = null!;
	public NetworksEventsSection Events { get; internal set; } = new();
	public INetworksFirmwareUpgrades FirmwareUpgrades { get; internal set; } = null!;
	public INetworksFloorplans Floorplans { get; internal set; } = null!;
	public INetworksGroupPolicies GroupPolicies { get; internal set; } = null!;
	public NetworksHealthSection Health { get; internal set; } = new();
	public INetworksMerakiAuthUsers MerakiAuthUsers { get; internal set; } = null!;
	public INetworksMqttBrokers MqttBrokers { get; internal set; } = null!;
	public INetworksNetflow Netflow { get; internal set; } = null!;
	public NetworksPiiSection Pii { get; internal set; } = new();
	public INetworksTraffic Traffic { get; internal set; } = null!;
	public INetworksTrafficAnalysis TrafficAnalysis { get; internal set; } = null!;
	public NetworksTrafficShapingSection TrafficShaping { get; internal set; } = new();
	public INetworksSettings Settings { get; internal set; } = null!;
	public INetworksSnmp Snmp { get; internal set; } = null!;
	public INetworksSplashLoginAttempts SplashLoginAttempts { get; internal set; } = null!;
	public INetworksSyslogServers SyslogServers { get; internal set; } = null!;
	public INetworksVlanProfiles VlanProfiles { get; internal set; } = null;
	public NetworksWebhooksSection Webhooks { get; internal set; } = new();
}