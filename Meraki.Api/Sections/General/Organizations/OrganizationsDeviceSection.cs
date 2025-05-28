namespace Meraki.Api.Sections.General.Organizations;
public partial class OrganizationsDeviceSection
{
	[RefitPromoteCalls]
	internal IOrganizationsDevices Devices { get; set; } = null!;

	public IOrganizationsDevicesController Controller { get; internal set; } = null!;

	public IOrganizationsDevicesPacketCapture PacketCapture { get; internal set; } = null!;

	public IOrganizationsDevicesPower Power { get; internal set; } = null!;

	public OrganizationsDevicesPowerModulesSection PowerModules { get; internal set; } = new();

	public IOrganizationsDevicesSignalQuality SignalQuality { get; internal set; } = null!;

	public OrganizationsDevicesSystemSection System { get; internal set; } = null!;

	public OrganizationsDevicesUplinksSection Uplinks { get; internal set; } = new();

	public IOrganizationsDevicesWirelessControllers WirelessControllers { get; internal set; } = null!;

}
