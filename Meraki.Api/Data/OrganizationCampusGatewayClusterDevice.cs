namespace Meraki.Api.Data;

/// <summary>
/// Device in the cluster
/// </summary>
[DataContract]
public class OrganizationCampusGatewayClusterDevice
{
	/// <summary>
	/// Member number assigned to the device within cluster - This is a read only attribute and cannot be altered using post/put operations
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "memberId")]
	public string MemberId { get; set; } = string.Empty;

	/// <summary>
	/// Serial of the device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Tunnel settings of the device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tunnels")]
	public List<OrganizationCampusGatewayClusterDeviceTunnel> Tunnels { get; set; } = [];

	/// <summary>
	/// Uplink settings of the device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "uplinks")]
	public List<OrganizationCampusGatewayClusterDeviceUplink> Uplinks { get; set; } = [];
}
