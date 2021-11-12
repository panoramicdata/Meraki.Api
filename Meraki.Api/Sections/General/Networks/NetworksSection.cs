namespace Meraki.Api.Sections.General.Networks;

public class NetworksSection
{
	public NetworksAlertsSection Alerts { get; internal set; } = new();
	public INetworksDevices Devices { get; internal set; } = null!;
	public INetworks Networks { get; internal set; } = null!;
	public INetworksBluetoothClients BluetoothClients { get; internal set; } = null!;
}
