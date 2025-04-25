namespace Meraki.Api.Sections.General.Devices;
public class DevicesWirelessSection
{
	public DevicesWirelessRadioSection Radio { get; set; }

	public DevicesWirelessAlternateManagementInterfaceSection AlternateManagementInterface { get; internal set; } = null!;
}
