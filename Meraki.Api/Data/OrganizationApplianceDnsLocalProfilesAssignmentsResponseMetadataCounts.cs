namespace Meraki.Api.Data;

/// <summary>
/// Counts relating to the paginated dataset
/// </summary>
[DataContract]
public class OrganizationApplianceDnsLocalProfilesAssignmentsResponseMetadataCounts
{
	/// <summary>
	/// Counts relating to the paginated items
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public OrganizationApplianceDnsLocalProfilesAssignmentsResponseMetadataCountsItems Items { get; set; } = new();
}
