namespace Meraki.Api.Data;

/// <summary>
/// Device in the cluster
/// </summary>
[DataContract]
public class NetworksCampusGatewayClusterDeviceDetailed
{
	/// <summary>
	/// Member number assigned to the device within cluster - This is a read only attribute and cannot be altered using post/put operations
	/// </summary>
	[DataMember(Name = "memberId")]
	[ApiAccess(ApiAccess.Create)]
	public string? MemberId { get; set; }

	/// <summary>
	/// Serial of the device
	/// </summary>
	[DataMember(Name = "serial")]
	[ApiAccess(ApiAccess.Create)]
	public string? Serial { get; set; }

	/// <summary>
	/// Tunnel settings of the device
	/// </summary>
	[DataMember(Name = "tunnels")]
	[ApiAccess(ApiAccess.Create)]
	public List<NetworksCampusGatewayClusterDeviceTunnel>? Tunnels { get; set; }

	/// <summary>
	/// Uplink settings of the device
	/// </summary>
	[DataMember(Name = "uplinks")]
	[ApiAccess(ApiAccess.Create)]
	public List<NetworksCampusGatewayClusterUplink>? Uplinks { get; set; }
}