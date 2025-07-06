namespace Meraki.Api.Data;

/// <summary>
/// An item in the bulk delete request
/// </summary>
[DataContract]
public class OrganizationApplianceDnsSplitProfilesAssignmentBulkDeleteRequestItem
{
	/// <summary>
	/// ID of the assignment
	/// </summary>
	[DataMember(Name = "assignmentId")]
	public string? AssignmentId { get; set; }
}