namespace Meraki.Api.Data;

/// <summary>
/// Counts relating to the paginated items
/// </summary>
[DataContract]
public class OrganizationApplianceDnsSplitProfilesAssignmentResponseMetadataCountsItems
{
	/// <summary>
	/// The number of items in the dataset that are available on subsequent pages
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "remaining")]
	public string Remaining { get; set; } = string.Empty;

	/// <summary>
	/// The total number of items in the dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}