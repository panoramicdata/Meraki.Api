namespace Meraki.Api.Data;

/// <summary>
/// Smart Port Profile association
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfilesNetworksAssignment
{
	/// <summary>
	/// Assignment ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "assignmentId")]
	public string AssignmentId { get; set; } = string.Empty;

	/// <summary>
	/// Type of network association
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// Network details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public OrganizationSwitchPortsProfilesNetworksAssignmentNetwork Network { get; set; } = new();

	/// <summary>
	/// Profile details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "profile")]
	public OrganizationSwitchPortsProfilesNetworksAssignmentProfile Profile { get; set; } = new();
}
