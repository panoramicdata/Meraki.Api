namespace Meraki.Api.Data;

/// <summary>
/// Number of packets processed by the switch system
/// </summary>
[DataContract]
public class OrganizationSwitchDevicesSystemQueuesHistoryBySwitchByIntervalItemHistoryCountsProcessed
{
	/// <summary>
	/// The total number of packets processed by the CPU during the snapshot
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }

	/// <summary>
	/// Information for processed packet counts, broken down by protocol
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "byProtocol")]
	public OrganizationSwitchDevicesSystemQueuesHistoryBySwitchByIntervalItemHistoryCountsByProtocol ByProtocol { get; set; } = new();
}