namespace Meraki.Api.Data;

/// <summary>
/// Organization Switch Ports Profiles Networks Assignments Batch Create Response
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfilesNetworksAssignmentsBatchCreateResponse
{
	/// <summary>
	/// List of Network - Smart Port Profile associations
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "items")]
	public List<OrganizationSwitchPortsProfilesNetworksAssignment> Items { get; set; } = [];
}
