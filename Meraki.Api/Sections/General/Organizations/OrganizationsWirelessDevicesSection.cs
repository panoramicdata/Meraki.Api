namespace Meraki.Api.Sections.General.Organizations;

public class OrganizationsWirelessDevicesSection
{
	public IOrganizationsWirelessDevicesChannelUtilization ChannelUtilization { get; internal set; } = null!;

	public IOrganizationsWirelessDevicesLatency Latency { get; internal set; } = null!;

	public IOrganizationsWirelessDevicesPacketLoss PacketLoss { get; internal set; } = null!;

	public IOrganizationsWirelessRadio Radio { get; internal set; } = null!;

	public OrganizationsWirelessRadsecSection Radsec { get; internal set; } = new();
}