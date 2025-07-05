namespace Meraki.Api.Data;

/// <summary>
/// The metadata for the returned datasets
/// </summary>
[DataContract]
public class OrganizationAssuranceProductAnnouncementsMetadata
{
	/// <summary>
	/// The count data for the returned datasets
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationAssuranceProductAnnouncementsMetadataCounts Counts { get; set; } = new();
}
