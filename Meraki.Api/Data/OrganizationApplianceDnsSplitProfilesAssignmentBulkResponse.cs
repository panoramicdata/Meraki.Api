namespace Meraki.Api.Data;

/// <summary>
/// Organization Appliance Dns Split Profiles Assignment Bulk Response
/// </summary>
[DataContract]
public class OrganizationApplianceDnsSplitProfilesAssignmentBulkResponse
{
	/// <summary>
	/// List of split DNS profile assignment
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public List<OrganizationApplianceDnsSplitProfilesAssignment> Items { get; set; } = [];
}
