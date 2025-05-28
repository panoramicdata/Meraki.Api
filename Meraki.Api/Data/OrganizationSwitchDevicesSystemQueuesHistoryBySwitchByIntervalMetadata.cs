namespace Meraki.Api.Data;

/// <summary>
/// Other metadata related to this result set.
/// </summary>
[DataContract]
public class OrganizationSwitchDevicesSystemQueuesHistoryBySwitchByIntervalMetadata
{
	/// <summary>
	/// Count metadata related to this result set.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationSwitchDevicesSystemQueuesHistoryBySwitchByIntervalMetadataCounts Counts { get; set; } = new();
}
