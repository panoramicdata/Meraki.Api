namespace Meraki.Api.Data;

/// <summary>
/// 
/// </summary>
[DataContract]
public class OrganizationDevicesSystemMemoryUsageHistoryByIntervalMetadata
{
	/// <summary>
	/// Count metadata related to this result set.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationDevicesSystemMemoryUsageHistoryByIntervalMetadataCounts Counts { get; set; } = new();
}
