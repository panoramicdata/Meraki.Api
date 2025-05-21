namespace Meraki.Api.Data;

/// <summary>
/// Assignment to delete
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfilesNetworksAssignmentsBulkDeleteItem
{
	/// <summary>
	/// Assignment ID
	/// </summary>
	[DataMember(Name = "assignmentId")]
	public string AssignmentId { get; set; } = string.Empty;
}