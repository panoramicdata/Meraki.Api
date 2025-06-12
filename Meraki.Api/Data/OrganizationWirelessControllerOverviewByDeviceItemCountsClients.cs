namespace Meraki.Api.Data;

/// <summary>
/// Wireless LAN controller client counts
/// </summary>
[DataContract]
public class OrganizationWirelessControllerOverviewByDeviceItemCountsClients
{
	/// <summary>
	/// Client counts by their status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "byStatus")]
	public OrganizationWirelessControllerOverviewByDeviceItemCountsClientsByStatus ByStatus { get; set; } = new();
}
