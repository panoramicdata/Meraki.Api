namespace Meraki.Api.Data;

/// <summary>
/// Information, over the given interval, for the number of packets processed and dropped by the device's data plane
/// </summary>
[DataContract]
public class OrganizationSwitchDevicesSystemQueuesHistoryBySwitchByIntervalItemStackMemberHistoryItem
{
	/// <summary>
	/// Timestamp for the end of the historical snapshot, inclusive.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "endTs")]
	public string EndTs { get; set; } = string.Empty;

	/// <summary>
	/// Timestamp for the beginning of the historical snapshot, exclusive.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "startTs")]
	public string StartTs { get; set; } = string.Empty;

	/// <summary>
	/// Information, over the given interval, for the number of packets processed and dropped by the device's data plane
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationSwitchDevicesSystemQueuesHistoryBySwitchByIntervalItemStackMemberHistoryItemCounts Counts { get; set; } = new();
}
