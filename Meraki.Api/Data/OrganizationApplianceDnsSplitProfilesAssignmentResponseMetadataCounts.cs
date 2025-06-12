namespace Meraki.Api.Data;

/// <summary>
/// Counts relating to the paginated dataset
/// </summary>
[DataContract]
public class OrganizationApplianceDnsSplitProfilesAssignmentResponseMetadataCounts
{
	/// <summary>
	/// Counts relating to the paginated items
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public OrganizationApplianceDnsSplitProfilesAssignmentResponseMetadataCountsItems Items { get; set; } = new();
}
