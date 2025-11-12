namespace Meraki.Api.Sections.Products.Wireless;

/// <summary>
/// Provides access to wireless API endpoints
/// </summary>
public class WirelessSection
{
	/// <summary>
	/// List Air Marshal scan results from a network
	/// </summary>

	public IWirelessAirMarshal AirMarshal { get; internal set; } = null!;
	/// <summary>
	/// Return an action batch
	/// </summary>

	public IWirelessAlternateManagementInterface AlternateManagementInterface { get; internal set; } = null!;
	/// <summary>
	/// Return the billing settings of this network
	/// </summary>

	public IWirelessBilling Billing { get; internal set; } = null!;
	/// <summary>
	/// Gets the bluetooth
	/// </summary>

	public WirelessBluetoothSection Bluetooth { get; internal set; } = new();
	/// <summary>
	/// Return AP channel utilization over time for a device or network client
	/// </summary>

	public IWirelessChannelUtilizationHistory ChannelUtilizationHistory { get; internal set; } = null!;
	/// <summary>
	/// Gets the clients
	/// </summary>

	public WirelessClientsSection Clients { get; internal set; } = new();
	/// <summary>
	/// Return wireless client counts over time for a network, device, or network client
	/// </summary>

	public IWirelessClientCountHistory ClientCountHistory { get; internal set; } = null!;
	/// <summary>
	/// Aggregated connectivity info for this network
	/// </summary>

	public IWirelessConnectionStats ConnectionStats { get; internal set; } = null!;
	/// <summary>
	/// Return a single device
	/// </summary>

	public WirelessDevicesSection Devices { get; internal set; } = new();
	/// <summary>
	/// Create an AP port profile
	/// </summary>

	public IWirelessEthernetPortsProfiles EthernetPortsProfile { get; internal set; } = null!;
	/// <summary>
	/// List of all failed client connection events on this network in a given time range
	/// </summary>

	public IWirelessFailedConnections FailedConnections { get; internal set; } = null!;
	/// <summary>
	/// Aggregated latency info for this network, grouped by clients
	/// </summary>

	public IWirelessLatencyHistory LatencyHistory { get; internal set; } = null!;
	/// <summary>
	/// Aggregated latency info for a given AP on this network
	/// </summary>

	public IWirelessLatencyStats LatencyStats { get; internal set; } = null!;
	/// <summary>
	/// Aggregated latency info for this network, grouped by clients
	/// </summary>

	public IWirelessMeshStatuses MeshStatuses { get; internal set; } = null!;
	/// <summary>
	/// Creates new RF profile for this network
	/// </summary>

	public IWirelessRfProfiles RfProfiles { get; internal set; } = null!;
	/// <summary>
	/// Gets the radio
	/// </summary>

	public WirelessRadioSection Radio { get; internal set; } = new();
	/// <summary>
	/// Return signal quality (SNR/RSSI) over time for a device or network client
	/// </summary>

	public IWirelessSignalQualityHistory SignalQualityHistory { get; internal set; } = null!;
	/// <summary>
	/// Gets the ssids
	/// </summary>

	public WirelessSsidsSection Ssids { get; internal set; } = new();
	/// <summary>
	/// Return the wireless settings for a network
	/// </summary>

	public IWirelessSettings Settings { get; internal set; } = null!;
	/// <summary>
	/// Return the SSID statuses of an access point
	/// </summary>

	public IWirelessStatus Status { get; internal set; } = null!;
	/// <summary>
	/// Return AP usage over time for a device or network client
	/// </summary>

	public IWirelessUsageHistory UsageHistory { get; internal set; } = null!;
}
