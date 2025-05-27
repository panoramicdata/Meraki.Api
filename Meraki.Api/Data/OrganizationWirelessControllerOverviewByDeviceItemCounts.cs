namespace Meraki.Api.Data;

/// <summary>
/// Wireless LAN controller client and access point counts
/// </summary>
[DataContract]
public class OrganizationWirelessControllerOverviewByDeviceItemCounts
{
	/// <summary>
	/// Wireless LAN controller client counts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "clients")]
	public OrganizationWirelessControllerOverviewByDeviceItemCountsClients Clients { get; set; } = new();

	/// <summary>
	/// Wireless LAN controller associated access point counts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "connections")]
	public OrganizationWirelessControllerOverviewByDeviceItemCountsConnections Connections { get; set; } = new();
}
