namespace Meraki.Api.Data;

/// <summary>
/// Wireless LAN controller redundancy failover information
/// </summary>
[DataContract]
public class OrganizationWirelessControllerDevicesRedundancyStatusesItemFailover
{
	/// <summary>
	/// Wireless LAN controller switchover counts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationWirelessControllerDevicesRedundancyStatusesItemFailoverCounts Counts { get; set; } = new();

	/// <summary>
	/// Wireless LAN controller last failover information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "last")]
	public OrganizationWirelessControllerDevicesRedundancyStatusesItemFailoverLast Last { get; set; } = new();
}
