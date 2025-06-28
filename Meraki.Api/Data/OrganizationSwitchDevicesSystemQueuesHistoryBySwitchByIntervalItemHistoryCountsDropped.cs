namespace Meraki.Api.Data;

/// <summary>
/// Number of packets dropped by the switch system
/// </summary>
[DataContract]
public class OrganizationSwitchDevicesSystemQueuesHistoryBySwitchByIntervalItemHistoryCountsDropped
{
	/// <summary>
	/// The total number of packets dropped by the CPU during the snapshot
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }

	/// <summary>
	/// Number of dropped packets, broken down by protocol
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "byProtocol")]
	public OrganizationSwitchDevicesSystemQueuesHistoryBySwitchByIntervalItemHistoryCountsByProtocol ByProtocol { get; set; } = new();
}
