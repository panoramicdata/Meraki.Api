namespace Meraki.Api.Sections.General.Devices;

public partial class DevicesSection
{
	[RefitPromoteCalls]
	internal IDevices Devices { get; set; } = null!;

	public IDeviceClients Clients { get; internal set; } = null!;
	public IDeviceLldpCdp LldpCdp { get; internal set; } = null!;
	public IDeviceLossAndLatencyHistory LossAndLatencyHistory { get; internal set; } = null!;
	public IDeviceManagementInterface ManagementInterface { get; internal set; } = null!;
}
