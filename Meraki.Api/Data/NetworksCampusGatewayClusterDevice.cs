namespace Meraki.Api.Data;

/// <summary>
/// Device to be added to the cluster
/// </summary>
public class NetworksCampusGatewayClusterDevice
{
	/// <summary>
	/// Serial of the device
	/// </summary>
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Tunnel settings of the device when tunnel interface of cluster is specified
	/// </summary>
	[DataMember(Name = "tunnels")]
	public List<NetworksCampusGatewayClusterDeviceTunnel>? Tunnels { get; set; }

	/// <summary>
	/// Uplink interface settings of the cluster
	/// </summary>
	[DataMember(Name = "uplinks")]
	public NetworksCampusGatewayClusterUplink Uplinks { get; set; } = new();
}