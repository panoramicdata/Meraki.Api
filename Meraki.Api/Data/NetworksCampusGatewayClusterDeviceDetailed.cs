namespace Meraki.Api.Data;

/// <summary>
/// Device in the cluster
/// </summary>
public class NetworksCampusGatewayClusterDeviceDetailed
{
	/// <summary>
	/// Member number assigned to the device within cluster - This is a read only attribute and cannot be altered using post/put operations
	/// </summary>
	public string? MemberId { get; set; }

	/// <summary>
	/// Serial of the device
	/// </summary>
	public string? Serial { get; set; }

	/// <summary>
	/// Tunnel settings of the device
	/// </summary>
	public List<NetworksCampusGatewayClusterDeviceTunnel>? Tunnels { get; set; }

	/// <summary>
	/// Uplink settings of the device
	/// </summary>
	public List<NetworksCampusGatewayClusterUplink>? Uplinks { get; set; }
}