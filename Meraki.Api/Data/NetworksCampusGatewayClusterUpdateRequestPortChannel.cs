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
	public int? Vlan { get; set; }

	/// <summary>
	/// Allowed VLANs of the port channel
	/// </summary>
	[DataMember(Name = "allowedVlans")]
	public string? AllowedVlans { get; set; }

	/// <summary>
	/// Name of the port channel
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}