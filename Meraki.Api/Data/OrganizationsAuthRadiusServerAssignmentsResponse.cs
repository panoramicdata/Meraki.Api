namespace Meraki.Api.Data;

/// <summary>
/// Organizations Auth Radius Server Assignments Response
/// </summary>
[DataContract]
public class OrganizationsAuthRadiusServerAssignmentsResponse
{
	/// <summary>
	/// The name of the RADIUS server
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The id of the RADIUS server
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serverId")]
	public string ServerId { get; set; } = string.Empty;

	/// <summary>
	/// List of entities where the org-wide RADIUS server is used
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "assignments")]
	public List<OrganizationsAuthRadiusServerAssignment> Assignments { get; set; } = [];
}
