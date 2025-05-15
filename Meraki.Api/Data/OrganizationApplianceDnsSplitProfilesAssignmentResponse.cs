namespace Meraki.Api.Data;

/// <summary>
/// Organizations Appliance Dns Split Profile Assignment Response
/// </summary>
[DataContract]
public class OrganizationApplianceDnsSplitProfilesAssignmentResponse
{
	/// <summary>
	/// Metadata relevant to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationApplianceDnsSplitProfilesAssignmentResponseMetadata Meta { get; set; } = new();

	/// <summary>
	/// List of split DNS profile assignment
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationApplianceDnsSplitProfilesAssignment> Items { get; set; } = [];
}
