namespace Meraki.Api.Data;

/// <summary>
/// Organization Switch Ports Profiles Networks Assignments Bulk Delete Request
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfilesNetworksAssignmentsBulkDeleteRequest
{
	/// <summary>
	/// Array of assignments to delete
	/// </summary>
	[DataMember(Name = "items")]
	public List<OrganizationSwitchPortsProfilesNetworksAssignmentsBulkDeleteItem> Items { get; set; } = [];
}
