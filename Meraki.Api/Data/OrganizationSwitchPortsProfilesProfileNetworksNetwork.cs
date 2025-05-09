namespace Meraki.Api.Data;

/// <summary>
/// An associated network
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfilesProfileNetworksNetwork
{
	/// <summary>
	/// The ID of the network / associated node group
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// The name of network / associated node group
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}