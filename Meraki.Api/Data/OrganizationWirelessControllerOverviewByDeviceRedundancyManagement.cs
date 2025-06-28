namespace Meraki.Api.Data;

/// <summary>
/// Wireless LAN controller redundancy management interface information
/// </summary>
[DataContract]
public class OrganizationWirelessControllerOverviewByDeviceRedundancyManagement
{
	/// <summary>
	/// Wireless LAN controller redundancy management interface addresses
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "addresses")]
	public List<OrganizationWirelessControllerOverviewByDeviceRedundancyManagementAddress> Addresses { get; set; } = [];
}
