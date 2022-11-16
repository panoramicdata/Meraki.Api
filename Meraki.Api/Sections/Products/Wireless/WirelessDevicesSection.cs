namespace Meraki.Api.Sections.Products.Wireless;

public class WirelessDevicesSection
{
	public IWirelessDeviceConnectionStats ConnectionStats { get; internal set; } = null!;
	public IWirelessDeviceLatencyStats LatencyStats { get; internal set; } = null!;
	public IWirelessDeviceEthernetStatuses OrganizationEthernetStatuses { get; internal set; } = null!;
}