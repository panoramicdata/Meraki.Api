namespace Meraki.Api.Data;

/// <summary>
/// Information, over the given interval, for the number of packets processed and dropped within the entire switch system. For standalone switches, this is the switch. For stacked switches, this is the entire stack.
/// </summary>
[DataContract]
public class OrganizationSwitchDevicesSystemQueuesHistoryBySwitchByIntervalItemHistoryCounts
{
	/// <summary>
	/// Number of packets dropped by the switch system
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dropped")]
	public OrganizationSwitchDevicesSystemQueuesHistoryBySwitchByIntervalItemHistoryCountsDropped Dropped { get; set; } = new();

	/// <summary>
	/// Number of packets processed by the switch system
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "processed")]
	public OrganizationSwitchDevicesSystemQueuesHistoryBySwitchByIntervalItemHistoryCountsProcessed Processed { get; set; } = new();
}
