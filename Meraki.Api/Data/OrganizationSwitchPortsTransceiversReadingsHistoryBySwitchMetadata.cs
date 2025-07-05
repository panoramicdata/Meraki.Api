namespace Meraki.Api.Data;

/// <summary>
/// Other metadata related to this result set.
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadata
{
	/// <summary>
	/// Count metadata related to this result set.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataCounts Counts { get; set; } = new();

	/// <summary>
	/// Information about which units each reading is provided in
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "units")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataUnits Units { get; set; } = new();

	/// <summary>
	/// Thresholds to be applied to each metric in order to derive error/warning states.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "thresholds")]
	public List<OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThreshold> Thresholds { get; set; } = [];
}
