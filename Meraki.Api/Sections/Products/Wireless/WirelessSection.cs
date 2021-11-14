
namespace Meraki.Api.Sections.Products.Wireless;

public class WirelessSection
{
	public IWirelessAirMarshal AirMarshal { get; internal set; } = null!;
	public IWirelessBilling Billing { get; internal set; } = null!;
	public IWirelessChannelUtilizationHistory ChannelUtilizationHistory { get; internal set; } = null!;
	public WirelessClientsSection Clients { get; internal set; } = null!;
	public IWirelessClientCountHistory ClientCountHistory { get; internal set; } = null!;
	public IWirelessConnectionStats ConnectionStats { get; internal set; } = null!;
	public WirelessDevicesSection Devices { get; internal set; } = new();
	public IWirelessFailedConnections FailedConnections { get; internal set; } = null!;
	public IWirelessLatencyHistory LatencyHistory { get; internal set; } = null!;
	public IWirelessLatencyStats LatencyStats { get; internal set; } = null!;
	public IWirelessMeshStatuses MeshStatuses { get; internal set; } = null!;
	public IWirelessRfProfiles RfProfiles { get; internal set; } = null!;
	public WirelessRadioSection Radio { get; internal set; } = new();
	public ISignalQualityHistory SignalQualityHistory { get; internal set; } = null!;
	public WirelessSsidsSection Ssids { get; internal set; } = new();
	public IWirelessSettings Settings { get; internal set; } = null!;
}
