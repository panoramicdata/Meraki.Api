namespace Meraki.Api.Data;

/// <summary>
/// Identifying information of the switch's network.
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTopologyDiscoveryByDeviceItemNetwork
{
	/// <summary>
	/// The ID of the network. 
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// The name of the network.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}