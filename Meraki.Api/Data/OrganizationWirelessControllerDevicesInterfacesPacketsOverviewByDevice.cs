namespace Meraki.Api.Data;

/// <summary>
/// Organization Wireless Controller Devices Interfaces Packets Overview By Device
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesInterfacesPacketsOverviewByDevice
{
	/// <summary>
	/// Metadata relevant to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationWirelessControllerDevicesInterfacesPacketsOverviewByDeviceMetadata Meta { get; set; } = new();

	/// <summary>
	/// Wireless LAN controller interfaces packets statuses
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationWirelessControllerDevicesInterfacesPacketsOverviewByDeviceItem> Items { get; set; } = [];
}
