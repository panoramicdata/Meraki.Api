namespace Meraki.Api.Data;

/// <summary>
/// Organization Appliance Dns Split Profiles Assignment Bulk Create Request
/// </summary>
[DataContract]
public class OrganizationApplianceDnsSplitProfilesAssignmentBulkCreateRequest
{
	/// <summary>
	/// List containing the network ID and Profile ID
	/// </summary>
	[DataMember(Name = "items")]
	public List<OrganizationApplianceDnsSplitProfilesAssignmentBulkCreateRequestItem> Items { get; set; } = [];
}
