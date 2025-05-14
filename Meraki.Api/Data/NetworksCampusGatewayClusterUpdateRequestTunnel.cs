namespace Meraki.Api.Data;

/// <summary>
/// Tunnel interface setting of the cluster: Reuse uplink or specify tunnel interface
/// </summary>
[DataContract]
public class NetworksCampusGatewayClusterUpdateRequestTunnel
{
	/// <summary>
	/// VLAN ID of the interface
	/// </summary>
	[DataMember(Name = "vlan")]
	public int? Vlan { get; set; }

	/// <summary>
	/// Uplink interface details if uplink is reused as tunnel
	/// </summary>
	[DataMember(Name = "uplink")]
	public NetworksCampusGatewayClusterUpdateRequestTunnelUplink? Uplink { get; set; }

	/// <summary>
	/// Addresses of the interface
	/// </summary>
	[DataMember(Name = "addresses")]
	public List<NetworksCampusGatewayClusterUpdateRequestAddress>? Addresses { get; set; }
}
