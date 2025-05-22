﻿namespace Meraki.Api.Sections.Products.Wireless;

public class WirelessSection
{
	public IWirelessAirMarshal AirMarshal { get; internal set; } = null!;
	public IWirelessAlternateManagementInterface AlternateManagementInterface { get; internal set; } = null!;
	public IWirelessBilling Billing { get; internal set; } = null!;
	public WirelessBluetoothSection Bluetooth { get; internal set; } = new();
	public IWirelessChannelUtilizationHistory ChannelUtilizationHistory { get; internal set; } = null!;
	public WirelessClientsSection Clients { get; internal set; } = new();
	public IWirelessClientCountHistory ClientCountHistory { get; internal set; } = null!;
	public IWirelessConnectionStats ConnectionStats { get; internal set; } = null!;
	public WirelessDevicesSection Devices { get; internal set; } = new();
	public IWirelessEthernetPortsProfiles EthernetPortsProfile { get; internal set; } = null!;
	public IWirelessFailedConnections FailedConnections { get; internal set; } = null!;
	public IWirelessLatencyHistory LatencyHistory { get; internal set; } = null!;
	public IWirelessLatencyStats LatencyStats { get; internal set; } = null!;
	public IWirelessMeshStatuses MeshStatuses { get; internal set; } = null!;
	public IWirelessRfProfiles RfProfiles { get; internal set; } = null!;
	public WirelessRadioSection Radio { get; internal set; } = new();
	public IWirelessSignalQualityHistory SignalQualityHistory { get; internal set; } = null!;
	public WirelessSsidsSection Ssids { get; internal set; } = new();
	public IWirelessSettings Settings { get; internal set; } = null!;
	public IWirelessStatus Status { get; internal set; } = null!;
	public IWirelessUsageHistory UsageHistory { get; internal set; } = null!;
}
