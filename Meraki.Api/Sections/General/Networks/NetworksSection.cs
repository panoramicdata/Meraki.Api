namespace Meraki.Api.Sections.General.Networks;

public partial class NetworksSection
{
	[RefitPromoteCalls]
	internal INetworks Networks { get; set; } = null!;
	/// <summary>
	/// Gets the alerts
	/// </summary>

	public NetworksAlertsSection Alerts { get; internal set; } = new();

	/// <summary>
	/// Gets the appliance
	/// </summary>

	public NetworksApplianceSection Appliance { get; internal set; } = new();

	/// <summary>
	/// Return a Bluetooth client
	/// </summary>

	public INetworksBluetoothClients BluetoothClients { get; internal set; } = null!;
	/// <summary>
	/// Create a cluster and add campus gateways to it
	/// </summary>

	public INetworksCampusGateway CampusGateway { get; internal set; } = null!;
	/// <summary>
	/// Gets the clients
	/// </summary>

	public NetworksClientsSection Clients { get; internal set; } = new();
	/// <summary>
	/// List the devices in a network
	/// </summary>

	public INetworksDevices Devices { get; internal set; } = null!;
	/// <summary>
	/// Gets the events
	/// </summary>

	public NetworksEventsSection Events { get; internal set; } = new();
	/// <summary>
	/// Get firmware upgrade information for a network
	/// </summary>

	public INetworksFirmwareUpgrades FirmwareUpgrades { get; internal set; } = null!;
	/// <summary>
	/// List the floor plans that belong to your network
	/// </summary>

	public INetworksFloorplans Floorplans { get; internal set; } = null!;
	/// <summary>
	/// List the group policies in a network
	/// </summary>

	public INetworksGroupPolicies GroupPolicies { get; internal set; } = null!;
	/// <summary>
	/// Gets the health
	/// </summary>

	public NetworksHealthSection Health { get; internal set; } = new();

	/// <summary>
	/// Return scanning API settings
	/// </summary>

	public INetworksLocationScanning LocationScanning { get; internal set; } = null!;

	/// <summary>
	/// List the users configured under Meraki Authentication for a network
	/// </summary>

	public INetworksMerakiAuthUsers MerakiAuthUsers { get; internal set; } = null!;
	/// <summary>
	/// List the MQTT brokers for this network
	/// </summary>

	public INetworksMqttBrokers MqttBrokers { get; internal set; } = null!;
	/// <summary>
	/// Return the NetFlow traffic reporting settings for a network
	/// </summary>

	public INetworksNetflow Netflow { get; internal set; } = null!;
	/// <summary>
	/// Gets the pii
	/// </summary>

	public NetworksPiiSection Pii { get; internal set; } = new();

	/// <summary>
	/// Get policies for all clients with policies
	/// </summary>

	public INetworksPolicies Policies { get; internal set; } = null!;

	/// <summary>
	/// Gets the sensor
	/// </summary>

	public NetworksSensorSection Sensor { get; internal set; } = new();

	/// <summary>
	/// Install applications on a device
	/// </summary>

	public INetworksSm Sm { get; internal set; } = null!;

	/// <summary>
	/// Return the traffic analysis data for this network
	/// </summary>

	public INetworksTraffic Traffic { get; internal set; } = null!;
	/// <summary>
	/// Return the traffic analysis settings for a network
	/// </summary>

	public INetworksTrafficAnalysis TrafficAnalysis { get; internal set; } = null!;
	/// <summary>
	/// Gets the traffic shaping
	/// </summary>

	public NetworksTrafficShapingSection TrafficShaping { get; internal set; } = new();
	/// <summary>
	/// Return the settings for a network
	/// </summary>

	public INetworksSettings Settings { get; internal set; } = null!;
	/// <summary>
	/// Return the SNMP settings for a network
	/// </summary>

	public INetworksSnmp Snmp { get; internal set; } = null!;

	/// <summary>
	/// Gets the switch
	/// </summary>

	public NetworksSwitchSection Switch { get; set; } = null!;
	/// <summary>
	/// List the splash login attempts for a network
	/// </summary>

	public INetworksSplashLoginAttempts SplashLoginAttempts { get; internal set; } = null!;
	/// <summary>
	/// List the syslog servers for a network
	/// </summary>

	public INetworksSyslogServers SyslogServers { get; internal set; } = null!;
	/// <summary>
	/// Create a Vlan profile on a network
	/// </summary>

	public INetworksVlanProfiles VlanProfiles { get; internal set; } = null!;
	/// <summary>
	/// Gets the wireless
	/// </summary>

	public NetworksWirelessSection Wireless { get; internal set; } = new();
	/// <summary>
	/// Gets the webhooks
	/// </summary>

	public NetworksWebhooksSection Webhooks { get; internal set; } = new();
}
