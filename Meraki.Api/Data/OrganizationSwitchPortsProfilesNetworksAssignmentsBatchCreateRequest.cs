namespace Meraki.Api.Data;

/// <summary>
/// Organization Switch Ports Profiles Networks Assignments Batch Create Request.
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfilesNetworksAssignmentsBatchCreateRequest
{
	/// <summary>
	/// Array of network and profile associations
	/// </summary>
	[DataMember(Name = "items")]
	public List<OrganizationSwitchPortsProfilesNetworksAssignmentCreateRequest> Items { get; set; } = [];
}
