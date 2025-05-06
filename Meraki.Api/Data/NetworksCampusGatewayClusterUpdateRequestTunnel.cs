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
	[ApiAccess(ApiAccess.Update)]
	public int? Vlan { get; set; }

	/// <summary>
	/// Uplink interface details if uplink is reused as tunnel
	/// </summary>
	[DataMember(Name = "uplink")]
	[ApiAccess(ApiAccess.Update)]
	public NetworksCampusGatewayClusterUpdateRequestTunnelUplink? Uplink { get; set; }

	/// <summary>
	/// Addresses of the interface
	/// </summary>
	[DataMember(Name = "addresses")]
	[ApiAccess(ApiAccess.Update)]
	public List<NetworksCampusGatewayClusterUpdateRequestAddress>? Addresses { get; set; }
}
