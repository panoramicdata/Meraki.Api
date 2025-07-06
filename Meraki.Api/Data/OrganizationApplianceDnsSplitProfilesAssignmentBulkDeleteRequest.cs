namespace Meraki.Api.Data;

/// <summary>
/// Organization Appliance Dns Split Profiles Assignment Bulk Delete Request
/// </summary>
[DataContract]
public class OrganizationApplianceDnsSplitProfilesAssignmentBulkDeleteRequest
{
	/// <summary>
	/// List containing the assignment ID
	/// </summary>
	[DataMember(Name = "items")]
	public List<OrganizationApplianceDnsSplitProfilesAssignmentBulkDeleteRequestItem> Items { get; set; } = [];
}
