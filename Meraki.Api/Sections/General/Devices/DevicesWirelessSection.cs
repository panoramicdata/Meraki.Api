namespace Meraki.Api.Sections.General.Devices;
public partial class DevicesWirelessSection
{
	[RefitPromoteCalls]
	internal IDevicesWireless DevicesWireless { get; set; } = null!;

	/// <summary>
	/// Update alternate management interface IPv6 address
	/// </summary>

	public IDeviceWirelessAlternateManagementInterface AlternateManagementInterface { get; internal set; } = null!;

	/// <summary>
	/// Gets the radio
	/// </summary>

	public DevicesWirelessRadioSection Radio { get; internal set; } = null!;

	/// <summary>
	/// Gets the zigbee
	/// </summary>

	public DevicesWirelessZigbeeSection Zigbee { get; internal set; } = null!;
}
