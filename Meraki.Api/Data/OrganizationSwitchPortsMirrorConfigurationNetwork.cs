namespace Meraki.Api.Data;

/// <summary>
/// Network of the switch
/// </summary>
[DataContract]
public class OrganizationSwitchPortsMirrorConfigurationNetwork
{
	/// <summary>
	/// ID of network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// The name of the network
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}