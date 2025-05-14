namespace Meraki.Api.Data;

/// <summary>
/// Uplink setting of the device when uplink assignment mode of cluster is static
/// </summary>
[DataContract]
public class NetworksCampusGatewayClusterUpdateRequestDeviceUplink
{
	/// <summary>
	/// Uplink interface name
	/// </summary>
	[DataMember(Name = "interface")]
	public string Interface { get; set; } = string.Empty;

	/// <summary>
	/// Uplink IP addresses of the device
	/// </summary>
	[DataMember(Name = "addresses")]
	public List<NetworksCampusGatewayClusterUpdateRequestDeviceUplinkAddress> Addresses { get; set; } = [];
}
