namespace Meraki.Api.Data;

/// <summary>
/// Tunnel settings of the cluster
/// </summary>
[DataContract]
public class NetworksCampusGatewayClusterDeviceTunnelDetailed
{
	/// <summary>
	/// VLAN ID of the interface	
	/// </summary>
	[DataMember(Name = "vlan")]
	[ApiAccess(ApiAccess.Create)]
	public int? VLan { get; set; }

	/// <summary>
	/// Name of the Interface
	/// </summary>
	[DataMember(Name = "interface")]
	[ApiAccess(ApiAccess.Create)]
	public string? Interface { get; set; }

	/// <summary>
	/// Use uplink interface as tunnel interface
	/// </summary>
	[DataMember(Name = "uplink")]
	[ApiAccess(ApiAccess.Create)]
	public NetworksCampusGatewayClusterUplinkSimple? Uplink { get; set; }

	/// <summary>
	/// Addresses of the interface
	/// </summary>
	[DataMember(Name = "addresses")]
	[ApiAccess(ApiAccess.Create)]
	public List<NetworksCampusGatewayClusterDeviceIPAddressWithGatewayDetailed>? Addresses { get; set; }
}