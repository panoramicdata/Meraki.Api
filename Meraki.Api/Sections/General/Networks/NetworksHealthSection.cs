namespace Meraki.Api.Sections.General.Networks;

/// <summary>
/// Provides access to networks health API endpoints
/// </summary>
public class NetworksHealthSection
{
	/// <summary>
	/// Get the channel utilization over each radio for all APs in a network.
	/// </summary>

	public INetworksHealthChannelUtilization ChannelUtilization { get; internal set; } = null!;

	/// <summary>
	/// Return all global alerts on this network
	/// </summary>

	public INetworksHealthAlerts HealthAlerts { get; internal set; } = null!;
}
