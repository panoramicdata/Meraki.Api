namespace Meraki.Api.Data;

/// <summary>
/// Metadata relevant to the paginated dataset
/// </summary>
[DataContract]
public class OrganizationApplianceDnsSplitProfilesAssignmentResponseMetadata
{
	/// <summary>
	/// Counts relating to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public OrganizationApplianceDnsSplitProfilesAssignmentResponseMetadataCounts Counts { get; set; } = new();
}
