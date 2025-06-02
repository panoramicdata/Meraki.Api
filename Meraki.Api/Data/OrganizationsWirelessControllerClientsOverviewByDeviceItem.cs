namespace Meraki.Api.Data;

/// <summary>
/// Access point client information
/// </summary>
[DataContract]
public class OrganizationsWirelessControllerClientsOverviewByDeviceItem
{
	/// <summary>
	/// Access point Serial number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Associated client count on access point
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationsWirelessControllerClientsOverviewByDeviceItemCounts Counts { get; set; } = new();

	/// <summary>
	/// Access point network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public OrganizationsWirelessControllerClientsOverviewByDeviceItemNetwork Network { get; set; } = new();
}
