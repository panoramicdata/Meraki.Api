namespace Meraki.Api.Data;

/// <summary>
/// Tunnel interface settings of the cluster: Reuse uplink or specify tunnel interface
/// </summary>
public class NetworksCampusGatewayClusterTunnel
{
	/// <summary>
	/// VLAN ID of the interface
	/// </summary>
	[DataMember(Name = "vlan")]
	public int VLan { get; set; }

	/// <summary>
	/// Interface identifier, should be set to tun1. Specify this interface only if uplink isn't reused as tunnel
	/// </summary>
	[DataMember(Name = "interface")]
	public string Interface { get; set; } = string.Empty;

	/// <summary>
	/// Uplink interface identifier if uplink is reused as tunnel
	/// </summary>
	[DataMember(Name = "uplink")]
	public NetworksCampusGatewayClusterUplinkSimple Uplink { get; set; } = new();

	/// <summary>
	/// List of addresses of the interface
	/// </summary>
	public List<NetworksCampusGatewayClusterDeviceIPAddressWithGatewayDetailed> Addresses { get; set; } = [];
}
