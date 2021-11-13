namespace Meraki.Api.Sections.General.Networks;

public class NetworksSection
{
	public NetworksAlertsSection Alerts { get; internal set; } = new();
	public INetworksBluetoothClients BluetoothClients { get; internal set; } = null!;
	public NetworksClientsSection Clients { get; internal set; } = new();
	public INetworksDevices Devices { get; internal set; } = null!;
	public NetworksEventsSection Events { get; internal set; } = new();
	public INetworksFirmwareUpgrades FirmwareUpgrades { get; internal set; } = null!;
	public INetworks Networks { get; internal set; } = null!;
}
