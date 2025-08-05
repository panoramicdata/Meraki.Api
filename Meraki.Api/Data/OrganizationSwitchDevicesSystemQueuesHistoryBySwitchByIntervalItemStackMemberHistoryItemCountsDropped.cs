namespace Meraki.Api.Data;

/// <summary>
/// Number of packets dropped by the switch system
/// </summary>
[DataContract]
public class OrganizationSwitchDevicesSystemQueuesHistoryBySwitchByIntervalItemStackMemberHistoryItemCountsDropped
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
	public OrganizationSwitchDevicesSystemQueuesHistoryBySwitchByIntervalItemStackMemberHistoryItemCountsByProtocol
		ByProtocol
	{ get; set; } = new();
}
