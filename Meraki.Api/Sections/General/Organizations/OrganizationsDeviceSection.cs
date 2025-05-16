namespace Meraki.Api.Sections.General.Organizations;
public partial class OrganizationsDeviceSection
{
	[RefitPromoteCalls]
	public IOrganizationsDevices Devices { get; internal set; } = null!;

	public IOrganizationsDevicesPacketCapture PacketCapture { get; internal set; } = null!;

	public IOrganizationsDevicesController Controller { get; internal set; } = null!;
}
