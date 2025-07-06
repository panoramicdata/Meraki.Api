namespace Meraki.Api.Data;

/// <summary>
/// Wireless LAN controller redundancy management interface addresses
/// </summary>
[DataContract]
public class OrganizationWirelessControllerOverviewByDeviceRedundancyManagementAddress
{
	/// <summary>
	/// Wireless LAN controller redundancy management interface ip address
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;
}