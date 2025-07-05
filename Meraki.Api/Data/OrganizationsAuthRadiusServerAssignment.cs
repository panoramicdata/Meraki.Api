namespace Meraki.Api.Data;

/// <summary>
/// An entity where the org-wide RADIUS server is used.
/// </summary>
[DataContract]
public class OrganizationsAuthRadiusServerAssignment
{
	/// <summary>
	/// Configuration where it is assigned to
	/// </summary> 
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "assignee")]
	public OrganizationsAuthRadiusServerAssignmentAssignee Assignee { get; set; } = new();

	/// <summary>
	/// Network where this server is assigned to
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "network")]
	public OrganizationsAuthRadiusServerAssignmentNetwork Network { get; set; } = new();
}
