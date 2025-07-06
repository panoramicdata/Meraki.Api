namespace Meraki.Api.Data;

/// <summary>
/// Wireless LAN controller switchover counts
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesRedundancyStatusesItemFailoverCounts
{
	/// <summary>
	/// Total number of failovers
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}