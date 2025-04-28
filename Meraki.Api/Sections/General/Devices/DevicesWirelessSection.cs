namespace Meraki.Api.Sections.General.Devices;
public class DevicesWirelessSection
{
	public DevicesWirelessRadioSection Radio { get; set; }

	public IDeviceWirelessAlternateManagementInterface AlternateManagementInterface { get; internal set; } = null!;
}
