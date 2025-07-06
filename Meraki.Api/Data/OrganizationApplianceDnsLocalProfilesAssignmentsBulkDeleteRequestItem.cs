namespace Meraki.Api.Data;

/// <summary>
/// Item containing the assignment ID
/// </summary>
[DataContract]
public class OrganizationApplianceDnsLocalProfilesAssignmentsBulkDeleteRequestItem
{
	/// <summary>
	/// ID of the assignment
	/// </summary>
	[DataMember(Name = "assignmentId")]
	public string? AssignmentId { get; set; }
}