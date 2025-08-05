namespace Meraki.Api.Data;

/// <summary>
/// Organization Switch Ports Profiles Networks Assignment Create Request
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfilesNetworksAssignmentCreateRequest
{
	/// <summary>
	/// Type of association
	/// </summary>
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// Network object
	/// </summary>
	[DataMember(Name = "network")]
	public OrganizationSwitchPortsProfilesNetworksAssignmentNetwork Network { get; set; } = new();

	/// <summary>
	/// Smart Port Profile object
	/// </summary>
	[DataMember(Name = "profile")]
	public OrganizationSwitchPortsProfilesNetworksAssignmentProfile Profile { get; set; } = new();
}
