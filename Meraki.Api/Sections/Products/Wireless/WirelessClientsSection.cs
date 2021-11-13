namespace Meraki.Api.Sections.Products.Wireless;

public class WirelessClientsSection
{
	public IWirelessConnectionStats ConnectionStats { get; internal set; } = null!;
	public IWirelessLatencyStats LatencyStats { get; internal set; } = null!;
	public IWirelessConnectivityEvents ConnectivityEvents { get; internal set; } = null!;
	public IWirelessLatencyHistory LatencyHistory { get; internal set; } = null!;
}