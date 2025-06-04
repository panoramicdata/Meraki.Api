namespace Meraki.Api.Sections.General.Networks;
public class NetworksWirelessSection
{
	public INetworksWirelessClients Clients { get; internal set; } = null!;

	public INetworksWirelessDevices Devices { get; internal set; } = null!;

	public INetworksWirelessLocation Location { get; internal set; }

	public INetworksWirelessOpportunisticPcap OpportunisticPcap { get; internal set; } = null!;

	public INetworksWirelessZigbee Zigbee { get; internal set; } = null!;
}
