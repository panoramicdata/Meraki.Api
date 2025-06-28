namespace Meraki.Api.Data;

/// <summary>
/// Profile details
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfilesNetworksAssignmentProfile
{
	/// <summary>
	/// Profile ID
	/// </summary> 
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}