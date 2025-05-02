namespace Meraki.Api.Data;

/// <summary>
/// Tunnel interface settings of the cluster: Reuse uplink or specify tunnel interface
/// </summary>
[DataContract]
public class NetworksCampusGatewayClusterTunnel
{
	/// <summary>
	/// VLAN ID of the interface
	/// </summary>
	[DataMember(Name = "vlan")]
	[ApiAccess(ApiAccess.Create)]
	public int VLan { get; set; }

	/// <summary>
	/// Interface identifier, should be set to tun1. Specify this interface only if uplink isn't reused as tunnel
	/// </summary>
	[DataMember(Name = "interface")]
	[ApiAccess(ApiAccess.Create)]
	public string Interface { get; set; } = string.Empty;

	/// <summary>
	/// Uplink interface identifier if uplink is reused as tunnel
	/// </summary>
	[DataMember(Name = "uplink")]
	[ApiAccess(ApiAccess.Create)]
	public NetworksCampusGatewayClusterUplinkSimple Uplink { get; set; } = new();

	/// <summary>
	/// List of addresses of the interface
	/// </summary>
	[DataMember(Name = "addresses")]
	[ApiAccess(ApiAccess.Create)]
	public List<NetworksCampusGatewayClusterDeviceIPAddressWithGatewayDetailed> Addresses { get; set; } = [];
}
