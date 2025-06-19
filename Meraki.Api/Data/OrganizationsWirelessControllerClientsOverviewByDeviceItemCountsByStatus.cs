namespace Meraki.Api.Data;

/// <summary>
/// Associated client count on access point by status
/// </summary>
[DataContract]
public class OrganizationsWirelessControllerClientsOverviewByDeviceItemCountsByStatus
{
	/// <summary>
	/// Active client count
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "online")]
	public int Online { get; set; }
}