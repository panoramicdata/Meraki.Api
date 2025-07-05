namespace Meraki.Api.Data;

/// <summary>
/// Overview Item
/// </summary>
[DataContract]
public class OrganizationWirelessControllerClientsOverviewHistoryByDeviceByIntervalItem
{
	/// <summary>
	/// 
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Wireless LAN controller network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public OrganizationWirelessControllerClientsOverviewHistoryByDeviceByIntervalItemNetwork Network { get; set; } = new();

	/// <summary>
	/// Overview history of a wireless LAN controller
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "readings")]
	public List<OrganizationWirelessControllerClientsOverviewHistoryByDeviceByIntervalItemReading> Readings { get; set; } = [];
}
