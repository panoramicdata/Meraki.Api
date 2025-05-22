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
	[ApiAccess(ApiAccess.ReadWrite)]
	public string Interface { get; set; } = string.Empty;

	/// <summary>
	/// Uplink IP addresses of the device
	/// </summary>
	[DataMember(Name = "address")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public List<NetworksCampusGatewayClusterDeviceIPAddress> Addresses { get; set; } = [];
}
