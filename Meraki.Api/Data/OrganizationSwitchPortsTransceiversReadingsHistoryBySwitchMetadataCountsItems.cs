namespace Meraki.Api.Data;

/// <summary>
/// The count metadata.
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataCountsItems
{
	/// <summary>
	/// The number of serials remaining based on current pagination location within the dataset.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "remaining")]
	public int Remaining { get; set; }

	/// <summary>
	/// The total number of serials.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}