namespace Meraki.Api.Data;

/// <summary>
/// Uplink interface setting of the cluster
/// </summary>
[DataContract]
public class NetworksCampusGatewayClusterUpdateRequestUplink
{
	/// <summary>
	/// VLAN ID of the interface
	/// </summary>
	[DataMember(Name = "vlan")]
	public int? Vlan { get; set; }

	/// <summary>
	/// Interface identifier, should be set to man1
	/// </summary>
	[DataMember(Name = "interface")]
	public string? Interface { get; set; }

	/// <summary>
	/// Addresses of the interface
	/// </summary>
	[DataMember(Name = "addresses")]
	public List<NetworksCampusGatewayClusterUpdateRequestUplinkAddress>? Addresses { get; set; }
}
