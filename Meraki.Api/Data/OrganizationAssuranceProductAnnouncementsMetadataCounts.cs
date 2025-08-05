namespace Meraki.Api.Data;

/// <summary>
/// The count data for the returned datasets
/// </summary>
[DataContract]
public class OrganizationAssuranceProductAnnouncementsMetadataCounts
{
	/// <summary>
	/// The count data for the dataset: items
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public OrganizationAssuranceProductAnnouncementsMetadataCountsItems Items { get; set; } = new();
}
