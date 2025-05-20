namespace Meraki.Api.Data;

/// <summary>
/// Network details
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfilesNetworksAssignmentNetwork
{
	/// <summary>
	/// Network ID
	/// </summary> 
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}