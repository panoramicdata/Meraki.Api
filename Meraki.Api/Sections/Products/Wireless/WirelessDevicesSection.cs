namespace Meraki.Api.Sections.Products.Wireless;

/// <summary>
/// Provides access to wireless devices API endpoints
/// </summary>
public class WirelessDevicesSection
{
	/// <summary>
	/// Aggregated connectivity info for this network, grouped by node
	/// </summary>

	public IWirelessDeviceConnectionStats ConnectionStats { get; internal set; } = null!;
	/// <summary>
	/// Aggregated latency info for this network, grouped by node
	/// </summary>

	public IWirelessDeviceLatencyStats LatencyStats { get; internal set; } = null!;
	/// <summary>
	/// List the most recent Ethernet link speed, duplex, aggregation and power mode and status information for wireless devices.
	/// </summary>

	public IWirelessDeviceEthernetStatuses OrganizationEthernetStatuses { get; internal set; } = null!;
	/// <summary>
	/// List the most recent packet loss information for wireless devices.
	/// </summary>

	public IWirelessDevicePacketLoss PacketLoss { get; internal set; } = null!;
}
