namespace Meraki.Api.Data;

/// <summary>
/// Port channel setting of the cluster
/// </summary>
[DataContract]
public class NetworksCampusGatewayClusterUpdateRequestPortChannel
{
	/// <summary>
	/// VLAN ID of the port channel
	/// </summary>
	[DataMember(Name = "vlan")]
	[ApiAccess(ApiAccess.Update)]
	public int? Vlan { get; set; }

	/// <summary>
	/// Allowed VLANs of the port channel
	/// </summary>
	[DataMember(Name = "allowedVlans")]
	[ApiAccess(ApiAccess.Update)]
	public string? AllowedVlans { get; set; }

	/// <summary>
	/// Name of the port channel
	/// </summary>
	[DataMember(Name = "name")]
	[ApiAccess(ApiAccess.Update)]
	public string Name { get; set; } = string.Empty;
}