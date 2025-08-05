namespace Meraki.Api.Data;

/// <summary>
/// Access point Network
/// </summary>
[DataContract]
public class OrganizationsWirelessControllerClientsOverviewByDeviceItemNetwork
{
	/// <summary>
	/// Access point network ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}