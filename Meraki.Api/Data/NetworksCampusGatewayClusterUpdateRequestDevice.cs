namespace Meraki.Api.Data;

/// <summary>
/// Device in the cluster
/// </summary>
[DataContract]
public class NetworksCampusGatewayClusterUpdateRequestDevice
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
	public List<NetworksCampusGatewayClusterUpdateRequestDeviceTunnel>? Tunnels { get; set; }

	/// <summary>
	/// Uplink settings of the device when uplink assignment mode of cluster is static
	/// </summary>
	[DataMember(Name = "uplinks")]
	public List<NetworksCampusGatewayClusterUpdateRequestDeviceUplink>? Uplinks { get; set; }
}
