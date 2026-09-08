
namespace Meraki.Api;

/// <summary>
/// Builds the device-level API sections.
/// </summary>
/// <remarks>
/// Separated from the constructor, which was otherwise 555 lines of wiring, and split by section so
/// that no single file passes the size limit. Each builder reads the section property it is about to
/// replace, because <c>RefitFor</c> uses that value only to infer the interface type to implement.
/// </remarks>
// Codacy analyses each file on its own, so it cannot see the other parts of this class and reports
// 'partial' as gratuitous (S2333). The remaining parts live in the sibling MerakiClient files.
#pragma warning disable S2333
public partial class MerakiClient
{
	private DevicesSection BuildDevicesSection()
		=> new()
		{
			Devices = RefitFor(Devices.Devices),
			Appliance = BuildDevicesApplianceSection(),
			CellularSims = RefitFor(Devices.CellularSims),
			Clients = RefitFor(Devices.Clients),
			LldpCdp = RefitFor(Devices.LldpCdp),
			LossAndLatencyHistory = RefitFor(Devices.LossAndLatencyHistory),
			ManagementInterface = RefitFor(Devices.ManagementInterface),
			SensorCommands = RefitFor(Devices.SensorCommands),
			Wireless = BuildDevicesWirelessSection(),
		};

	private DevicesApplianceSection BuildDevicesApplianceSection()
		=> new()
		{
			Prefixes = RefitFor(Devices.Appliance.Prefixes)
		};

	private DevicesWirelessSection BuildDevicesWirelessSection()
		=> new()
		{
			DevicesWireless = RefitFor(Devices.Wireless.DevicesWireless),
			AlternateManagementInterface = RefitFor(Devices.Wireless.AlternateManagementInterface),
			Radio = BuildDevicesWirelessRadioSection(),
			Zigbee = BuildDevicesWirelessZigbeeSection()
		};

	private DevicesWirelessRadioSection BuildDevicesWirelessRadioSection()
		=> new()
		{
			Afc = RefitFor(Devices.Wireless.Radio.Afc)
		};

	private DevicesWirelessZigbeeSection BuildDevicesWirelessZigbeeSection()
		=> new()
		{
			Enrollments = RefitFor(Devices.Wireless.Zigbee.Enrollments)
		};
}
#pragma warning restore S2333
