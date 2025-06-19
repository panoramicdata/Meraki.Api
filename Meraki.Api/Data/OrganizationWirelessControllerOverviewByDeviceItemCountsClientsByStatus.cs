namespace Meraki.Api.Data;

/// <summary>
/// Client counts by their status
/// </summary>
[DataContract]
public class OrganizationWirelessControllerOverviewByDeviceItemCountsClientsByStatus
{
	/// <summary>
	/// Wireless LAN controller active client count
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "online")]
	public int Online { get; set; }
}