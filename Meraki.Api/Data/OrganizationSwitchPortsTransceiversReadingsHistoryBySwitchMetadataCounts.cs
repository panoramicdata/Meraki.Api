namespace Meraki.Api.Data;

/// <summary>
/// Count metadata related to this result set.
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataCounts
{
	/// <summary>
	/// The count metadata.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataCountsItems Items { get; set; } = new();
}
