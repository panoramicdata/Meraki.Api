namespace Meraki.Api.Data;

/// <summary>
/// DNS profile Assignment
/// </summary>
[DataContract]
public class OrganizationApplianceDnsSplitProfilesAssignment
{
	/// <summary>
	/// ID of the assignment
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "assignmentId")]
	public string AssignmentId { get; set; } = string.Empty;

	/// <summary>
	/// The network attached to the profile
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public OrganizationApplianceDnsSplitProfilesAssignmentNetwork Network { get; set; } = new();

	/// <summary>
	/// The profile the network is attached to
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "profile")]
	public OrganizationApplianceDnsSplitProfilesAssignmentProfile Profile { get; set; } = new();
}
