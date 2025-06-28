namespace Meraki.Api.Data;

/// <summary>
/// The count data for the dataset: items
/// </summary>
[DataContract]
public class OrganizationAssuranceProductAnnouncementsMetadataCountsItems
{
	/// <summary>
	/// The total number of items in the dataset 
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}