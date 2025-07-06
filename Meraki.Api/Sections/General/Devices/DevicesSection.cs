namespace Meraki.Api.Sections.General.Devices;

public partial class DevicesSection
{
	[RefitPromoteCalls]
	internal IDevices Devices { get; set; } = null!;

	public DevicesApplianceSection Appliance { get; set; }

	public IDeviceClients Clients { get; internal set; } = null!;

	public IDeviceCellularSims CellularSims { get; internal set; } = null!;

	public IDeviceLldpCdp LldpCdp { get; internal set; } = null!;

	public IDeviceLossAndLatencyHistory LossAndLatencyHistory { get; internal set; } = null!;

	public IDeviceManagementInterface ManagementInterface { get; internal set; } = null!;

	public DevicesWirelessSection Wireless { get; internal set; } = null!;

	public IDeviceSensorCommands SensorCommands { get; internal set; } = null!;
}
