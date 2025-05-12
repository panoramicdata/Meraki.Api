namespace Meraki.Api.Data;

/// <summary>
/// Network zigbee device is on
/// </summary>
public class OrganizationZigbeeNetworkDetailed
{
	/// <summary>
	/// The network id the zigbee node belongs too
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// The name of the Network
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}