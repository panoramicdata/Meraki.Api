namespace Meraki.Api.Data;

/// <summary>
/// Organization Appliance Dns Local Profiles Assignments Bulk Create Response
/// </summary>
[DataContract]
public class OrganizationApplianceDnsLocalProfilesAssignmentsBulkCreateResponse
{
	/// <summary>
	/// List of local DNS profile assignment
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public List<OrganizationApplianceDnsLocalProfilesAssignmentsDataItem> Items { get; set; } = [];
}
