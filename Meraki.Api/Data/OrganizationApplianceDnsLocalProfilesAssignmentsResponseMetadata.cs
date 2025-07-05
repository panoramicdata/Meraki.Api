namespace Meraki.Api.Data;

/// <summary>
/// Metadata relevant to the paginated dataset
/// </summary>
[DataContract]
public class OrganizationApplianceDnsLocalProfilesAssignmentsResponseMetadata
{
	/// <summary>
	/// Counts relating to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationApplianceDnsLocalProfilesAssignmentsResponseMetadataCounts Counts { get; set; } = new();
}
