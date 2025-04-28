namespace Meraki.Api.Data;

/// <summary>
/// An uplink setting of the device when uplink assignment mode of cluster is static
/// </summary>
public class NetworksCampusGatewayClusterUplinkDetailed
{
	/// <summary>
	/// VLAN ID of the interface
	/// </summary>
	[DataMember(Name = "vlan")]
	public int VLan { get; set; }

	/// <summary>
	/// nterface identifier, should be set to man1
	/// </summary>
	[DataMember(Name = "interface")]
	public string Interface { get; set; } = string.Empty;

	/// <summary>
	/// Addresses of the Interface
	/// </summary>
	public List<NetworksCampusGatewayClusterUplinkIPAddress> Addresses { get; set; } = [];
}