namespace Meraki.Api.Sections.General.Devices;
public partial class DevicesWirelessSection
{
	[RefitPromoteCalls]
	internal IDevicesWireless DevicesWireless { get; set; } = null!;

	public IDeviceWirelessAlternateManagementInterface AlternateManagementInterface { get; internal set; } = null!;

	public DevicesWirelessRadioSection Radio { get; internal set; } = null!;

	public DevicesWirelessZigbeeSection Zigbee { get; internal set; } = null!;
}
