namespace Meraki.Api.Data;

/// <summary>
/// Organization Appliance Dns Local Profiles Assignments Bulk Response
/// </summary>
[DataContract]
public class OrganizationApplianceDnsLocalProfilesAssignmentsBulkResponse
{
	/// <summary>
	/// List of local DNS profile assignment
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "items")]
	public List<OrganizationApplianceDnsLocalProfilesAssignmentsDataItem> Items { get; set; } = [];
}
