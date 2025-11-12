namespace Meraki.Api.Sections.General.Networks;

/// <summary>
/// Provides access to networks wireless API endpoints
/// </summary>
public class NetworksWirelessSection
{
	/// <summary>
	/// Fetch the health scores for all clients on this network
	/// </summary>

	public INetworksWirelessClients Clients { get; internal set; } = null!;

	/// <summary>
	/// Fetch the health scores of all APs on this network
	/// </summary>

	public INetworksWirelessDevices Devices { get; internal set; } = null!;

	/// <summary>
	/// Change scanning API settings
	/// </summary>

	public INetworksWirelessLocation Location { get; internal set; } = null!;

	/// <summary>
	/// Update the Opportunistic Pcap settings for a wireless network
	/// </summary>

	public INetworksWirelessOpportunisticPcap OpportunisticPcap { get; internal set; } = null!;

	/// <summary>
	/// Update the AutoRF settings for a wireless network
	/// </summary>

	public INetworksWirelessRadio Radio { get; internal set; } = null!;

	/// <summary>
	/// Update Zigbee Configs for specified network
	/// </summary>

	public INetworksWirelessZigbee Zigbee { get; internal set; } = null!;
}
