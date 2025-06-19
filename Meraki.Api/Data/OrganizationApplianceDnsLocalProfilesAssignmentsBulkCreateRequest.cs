namespace Meraki.Api.Data;

/// <summary>
/// Organization Appliance Dns Local Profiles Assignments Bulk Create Request
/// </summary>
[DataContract]
public class OrganizationApplianceDnsLocalProfilesAssignmentsBulkCreateRequest
{
	/// <summary>
	/// List containing the network ID and Profile ID
	/// </summary>
	[DataMember(Name = "items")]
	public List<OrganizationApplianceDnsLocalProfilesAssignmentsBulkCreateRequestDataItem> Items { get; set; } = [];
}
