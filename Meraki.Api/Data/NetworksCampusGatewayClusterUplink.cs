namespace Meraki.Api.Data;

/// <summary>
/// An uplink setting of the device when uplink assignment mode of cluster is static
/// </summary>
[DataContract]
public class NetworksCampusGatewayClusterUplink
{
	/// <summary>
	/// Uplink interface name
	/// </summary>
	[DataMember(Name = "interface")]
	[ApiAccess(ApiAccess.Create)]
	public string Interface { get; set; } = string.Empty;

	/// <summary>
	/// Uplink IP addresses of the device
	/// </summary>
	[DataMember(Name = "address")]
	[ApiAccess(ApiAccess.Create)]
	public List<NetworksCampusGatewayClusterDeviceIPAddress> Addresses { get; set; } = [];
}
