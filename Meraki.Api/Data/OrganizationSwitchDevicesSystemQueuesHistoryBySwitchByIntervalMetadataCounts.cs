namespace Meraki.Api.Data;

/// <summary>
/// Count metadata related to this result set.
/// </summary>
[DataContract]
public class OrganizationSwitchDevicesSystemQueuesHistoryBySwitchByIntervalMetadataCounts
{
	/// <summary>
	/// The count metadata.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public OrganizationSwitchDevicesSystemQueuesHistoryBySwitchByIntervalMetadataCountsItems Items { get; set; } = new();
}
