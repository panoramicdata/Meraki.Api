namespace Meraki.Api.Sections.General.Organizations;
public partial class OrganizationsDeviceSection
{
	[RefitPromoteCalls]
	internal IOrganizationsDevices Devices { get; set; } = null!;

	public IOrganizationsDevicesController Controller { get; internal set; } = null!;

	public IOrganizationsDevicesPacketCapture PacketCapture { get; internal set; } = null!;

	public IOrganizationsDevicesPower Power { get; internal set; } = null!;

	public OrganizationsDevicesPowerModulesSection PowerModules { get; set; } = new();

	public IOrganizationsDevicesSignalQuality SignalQuality { get; internal set; } = null!;

	public IOrganizationsDevicesSystem System { get; internal set; } = null!;

	public IOrganizationsDevicesWirelessControllers WirelessControllers { get; internal set; } = null!;

}
