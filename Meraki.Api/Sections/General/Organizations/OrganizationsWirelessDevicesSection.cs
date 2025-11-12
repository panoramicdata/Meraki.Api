namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations wireless devices API endpoints
/// </summary>
public class OrganizationsWirelessDevicesSection
{
	/// <summary>
	/// Get average channel utilization for all bands in a network, split by AP
	/// </summary>

	public IOrganizationsWirelessDevicesChannelUtilization ChannelUtilization { get; internal set; } = null!;

	/// <summary>
	/// Get latency summaries for all wireless devices in an organization.
	/// </summary>

	public IOrganizationsWirelessDevicesLatency Latency { get; internal set; } = null!;

	/// <summary>
	/// Get average packet loss for the given timespan for all clients in the organization.
	/// </summary>

	public IOrganizationsWirelessDevicesPacketLoss PacketLoss { get; internal set; } = null!;

	/// <summary>
	/// List the AFC power limits of an organization by device
	/// </summary>

	public IOrganizationsWirelessRadio Radio { get; internal set; } = null!;

	/// <summary>
	/// Gets the radsec
	/// </summary>

	public OrganizationsWirelessRadsecSection Radsec { get; internal set; } = new();
}
