namespace Meraki.Api.Sections.General.Networks;

[RefitClass("Networks")]
public partial class NetworksSection
{
    public INetworks Networks { get; set; } = null!;
    public NetworksAlertsSection Alerts { get; internal set; } = new();
    public INetworksBluetoothClients BluetoothClients { get; internal set; } = null!;
    public NetworksClientsSection Clients { get; internal set; } = new();
    public INetworksDevices Devices { get; internal set; } = null!;
    public NetworksEventsSection Events { get; internal set; } = new();
    public INetworksFirmwareUpgrades FirmwareUpgrades { get; internal set; } = null!;
    public INetworksFloorplans Floorplans { get; internal set; } = null!;
}

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
internal class RefitClassAttribute : Attribute
{
    public RefitClassAttribute(string propertyName)
    {
        PropertyName = propertyName;
    }

    public string PropertyName { get; }
}
