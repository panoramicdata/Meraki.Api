namespace Meraki.Api.Data;

/// <summary>
/// Counts relating to the paginated items
/// </summary>
[DataContract]
public class OrganizationSmAdminsRolesMetadataCountsItems
{
	/// <summary>
	/// The number of items in the dataset that are available on subsequent pages
	/// </summary>
	[DataMember(Name = "remaining")]
	public int Remaining { get; set; }

	/// <summary>
	/// The total number of items in the dataset
	/// </summary>
	[DataMember(Name = "total")]
	public int Total { get; set; }
}