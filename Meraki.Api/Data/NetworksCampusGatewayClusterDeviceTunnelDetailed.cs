namespace Meraki.Api.Data;

/// <summary>
/// Tunnel settings of the cluster
/// </summary>
public class NetworksCampusGatewayClusterDeviceTunnelDetailed
{
	/// <summary>
	/// VLAN ID of the interface	
	/// </summary>
	public int? VLan { get; set; }

	/// <summary>
	/// Name of the Interface
	/// </summary>
	public string? Interface { get; set; }

	/// <summary>
	/// Use uplink interface as tunnel interface
	/// </summary>
	public NetworksCampusGatewayClusterUplinkSimple? Uplink { get; set; }

	/// <summary>
	/// Addresses of the interface
	/// </summary>
	public List<NetworksCampusGatewayClusterDeviceIPAddressWithGatewayDetailed>? Addresses { get; set; }
}