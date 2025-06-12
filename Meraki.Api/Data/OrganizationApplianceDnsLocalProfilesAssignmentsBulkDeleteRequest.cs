namespace Meraki.Api.Data;

/// <summary>
/// Organization Appliance Dns Local Profiles Assignments Bulk Delete Request
/// </summary>
[DataContract]
public class OrganizationApplianceDnsLocalProfilesAssignmentsBulkDeleteRequest
{
	/// <summary>
	/// List containing the assignment ID
	/// </summary>
	[DataMember(Name = "items")]
	public List<OrganizationApplianceDnsLocalProfilesAssignmentsBulkDeleteRequestItem> Items { get; set; } = [];
}
