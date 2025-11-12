namespace Meraki.Api.Sections.Products.Wireless;

/// <summary>
/// Provides access to wireless clients API endpoints
/// </summary>
public class WirelessClientsSection
{
	/// <summary>
	/// Aggregated connectivity info for this network, grouped by clients
	/// </summary>

	public IWirelessClientsConnectionStats ConnectionStats { get; internal set; } = null!;
	/// <summary>
	/// Aggregated latency info for this network, grouped by clients
	/// </summary>

	public IWirelessClientsLatencyStats LatencyStats { get; internal set; } = null!;
	/// <summary>
	/// List the wireless connectivity events for a client within a network in the timespan.
	/// </summary>

	public IWirelessClientsConnectivityEvents ConnectivityEvents { get; internal set; } = null!;
	/// <summary>
	/// Return the latency history for a client
	/// </summary>

	public IWirelessClientsLatencyHistory LatencyHistory { get; internal set; } = null!;
}
