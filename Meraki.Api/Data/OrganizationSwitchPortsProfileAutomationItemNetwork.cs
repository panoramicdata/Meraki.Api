namespace Meraki.Api.Data;

/// <summary>
/// Associated Network
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfileAutomationItemNetwork
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