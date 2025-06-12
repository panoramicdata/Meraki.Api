namespace Meraki.Api.Data;

/// <summary>
/// A local DNS profile assignment
/// </summary>
[DataContract]
public class OrganizationApplianceDnsLocalProfilesAssignmentsDataItem
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
	public OrganizationApplianceDnsLocalProfilesAssignmentsDataItemNetwork Network { get; set; } = new();

	/// <summary>
	/// The profile the network is attached to
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "profile")]
	public OrganizationApplianceDnsLocalProfilesAssignmentsDataItemProfile Profile { get; set; } = new();
}
