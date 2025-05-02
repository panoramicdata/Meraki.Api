namespace Meraki.Api.Data;

/// <summary>
/// Device to be added to the cluster
/// </summary>
[DataContract]
public class NetworksCampusGatewayClusterDevice
{
	/// <summary>
	/// Serial of the device
	/// </summary>
	[DataMember(Name = "serial")]
	[ApiAccess(ApiAccess.Create)]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Tunnel settings of the device when tunnel interface of cluster is specified
	/// </summary>
	[DataMember(Name = "tunnels")]
	[ApiAccess(ApiAccess.Create)]
	public List<NetworksCampusGatewayClusterDeviceTunnel>? Tunnels { get; set; }

	/// <summary>
	/// Uplink interface settings of the cluster
	/// </summary>
	[DataMember(Name = "uplinks")]
	[ApiAccess(ApiAccess.Create)]
	public NetworksCampusGatewayClusterUplink Uplinks { get; set; } = new();
}