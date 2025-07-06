namespace Meraki.Api.Data;

/// <summary>
/// Wireless LAN controller network
/// </summary>
[DataContract]
public class OrganizationWirelessControllerOverviewByDeviceItemNetwork
{
	/// <summary>
	/// Wireless LAN controller network ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}