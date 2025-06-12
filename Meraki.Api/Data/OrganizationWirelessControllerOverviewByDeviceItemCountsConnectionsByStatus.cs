namespace Meraki.Api.Data;

/// <summary>
/// Access point counts by their status
/// </summary>
[DataContract]
public class OrganizationWirelessControllerOverviewByDeviceItemCountsConnectionsByStatus
{
	/// <summary>
	/// Wireless LAN controller associated offline access point count
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "offline")]
	public int Offline { get; set; }

	/// <summary>
	/// Wireless LAN controller associated online access point count
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "online")]
	public int Online { get; set; }
}