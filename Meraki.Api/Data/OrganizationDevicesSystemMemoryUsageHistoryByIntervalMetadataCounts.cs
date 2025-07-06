namespace Meraki.Api.Data;

/// <summary>
/// Count metadata related to this result set.
/// </summary>
[DataContract]
public class OrganizationDevicesSystemMemoryUsageHistoryByIntervalMetadataCounts
{
	/// <summary>
	/// The count metadata.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public OrganizationDevicesSystemMemoryUsageHistoryByIntervalMetadataCountsItems Items { get; set; } = new();
}
