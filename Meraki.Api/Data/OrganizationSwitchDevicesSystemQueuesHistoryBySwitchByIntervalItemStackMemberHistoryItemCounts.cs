namespace Meraki.Api.Data;

/// <summary>
/// Information, over the given interval, for the number of packets processed and dropped by the device's data plane
/// </summary>
[DataContract]
public class OrganizationSwitchDevicesSystemQueuesHistoryBySwitchByIntervalItemStackMemberHistoryItemCounts
{
	/// <summary>
	/// Number of packets dropped by the switch system
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dropped")]
	public OrganizationSwitchDevicesSystemQueuesHistoryBySwitchByIntervalItemStackMemberHistoryItemCountsDropped Dropped { get; set; } = new();

	/// <summary>
	/// Number of packets processed by the switch system
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "processed")]
	public OrganizationSwitchDevicesSystemQueuesHistoryBySwitchByIntervalItemStackMemberHistoryItemCountsProcessed Processed { get; set; } = new();
}
