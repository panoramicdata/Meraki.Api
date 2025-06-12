namespace Meraki.Api.Data;

/// <summary>
/// Organization Switch Ports Profiles Networks Assignments
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfilesNetworksAssignments
{
	/// <summary>
	/// Metadata relevant to the paginated dataset
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "meta")]
	public OrganizationSwitchPortsProfilesNetworksAssignmentsMetadata Meta { get; set; } = new();

	/// <summary>
	/// List of Network - Smart Port Profile associations
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationSwitchPortsProfilesNetworksAssignment> Items { get; set; } = [];
}
