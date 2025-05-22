namespace Meraki.Api.Sections.General.Devices;
public class DevicesWirelessSection
{
	public IDeviceWirelessAlternateManagementInterface AlternateManagementInterface { get; internal set; } = null!;

	public DevicesWirelessRadioSection Radio { get; internal set; } = null!;

	public DevicesWirelessZigbeeSection Zigbee { get; internal set; } = null!;
}
