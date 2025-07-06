namespace Meraki.Api.Data;

/// <summary>
/// Client counts by its status
/// </summary>
[DataContract]
public class OrganizationWirelessControllerClientsOverviewHistoryByDeviceByIntervalItemReadingCountsByStatus
{
	/// <summary>
	/// Number of connected clients
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "online")]
	public int Online { get; set; }
}