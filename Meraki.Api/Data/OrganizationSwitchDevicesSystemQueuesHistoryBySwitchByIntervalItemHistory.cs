namespace Meraki.Api.Data;

/// <summary>
/// The history of switch system data, with the most recent snapshot first
/// </summary>
[DataContract]
public class OrganizationSwitchDevicesSystemQueuesHistoryBySwitchByIntervalItemHistory
{
	/// <summary>
	/// Timestamp for the end of the switch system historical snapshot, inclusive.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "endTs")]
	public string EndTs { get; set; } = string.Empty;

	/// <summary>
	/// Timestamp for the beginning of the switch system historical snapshot, exclusive.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "startTs")]
	public string StartTs { get; set; } = string.Empty;

	/// <summary>
	/// Information, over the given interval, for the number of packets processed and dropped within the entire switch system. For standalone switches, this is the switch. For stacked switches, this is the entire stack.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationSwitchDevicesSystemQueuesHistoryBySwitchByIntervalItemHistoryCounts Counts { get; set; } = new();
}
