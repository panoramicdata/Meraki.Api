namespace Meraki.Api.Data;

/// <summary>
/// Organizations Wireless Controller Clients Overview By Device
/// </summary>
[DataContract]
public class OrganizationsWirelessControllerClientsOverviewByDevice
{
	/// <summary>
	/// Metadata relevant to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationsWirelessControllerClientsOverviewByDeviceMetadata Meta { get; set; } = new();

	/// <summary>
	/// Access point client count
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public List<OrganizationsWirelessControllerClientsOverviewByDeviceItem> Items { get; set; } = [];
}
