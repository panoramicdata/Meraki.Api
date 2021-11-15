namespace Meraki.Api.Sections.Products.Wireless;

public class WirelessClientsSection
{
	public IWirelessClientsConnectionStats ConnectionStats { get; internal set; } = null!;
	public IWirelessClientsLatencyStats LatencyStats { get; internal set; } = null!;
	public IWirelessClientsConnectivityEvents ConnectivityEvents { get; internal set; } = null!;
	public IWirelessClientsLatencyHistory LatencyHistory { get; internal set; } = null!;
}