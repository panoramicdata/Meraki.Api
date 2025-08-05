namespace Meraki.Api.Data;

/// <summary>
/// Organization Switch Devices System Queues History By Switch By Interval
/// </summary>
[DataContract]
public class OrganizationSwitchDevicesSystemQueuesHistoryBySwitchByInterval
{
	/// <summary>
	/// Other metadata related to this result set.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationSwitchDevicesSystemQueuesHistoryBySwitchByIntervalMetadata Meta { get; set; } = new();

	/// <summary>
	/// The top-level property containing all connectivity data.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public List<OrganizationSwitchDevicesSystemQueuesHistoryBySwitchByIntervalItem> Items { get; set; } = [];
}
