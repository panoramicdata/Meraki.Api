namespace Meraki.Api.Data;

/// <summary>
/// NetworksCampusGatewayClusterRequest
/// </summary>
[DataContract]
public class NetworksCampusGatewayClusterRequest
{
	/// <summary>
	/// Name of the new cluster
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Notes about cluster with max size of 511 characters allowed
	/// </summary>
	[DataMember(Name = "notes")]
	public string? Notes { get; set; }

	/// <summary>
	/// Nameservers of the cluster
	/// </summary>
	[DataMember(Name = "nameservers")]
	public List<NetworksCampusGatewayClusterNameservers> Nameservers { get; set; } = [];

	/// <summary>
	/// List of devices to be added to the cluster
	/// </summary>
	[DataMember(Name = "devices")]
	public List<NetworksCampusGatewayClusterDevice> Devices { get; set; } = [];

	/// <summary>
	/// List of Port channel settings of the cluster
	/// </summary>
	[DataMember(Name = "portChannels")]
	public List<NetworksCampusGatewayClusterPortchannel> PortChannels { get; set; } = [];

	/// <summary>
	/// List of Tunnel interface settings of the cluster
	/// </summary>
	[DataMember(Name = "tunnels")]
	public List<NetworksCampusGatewayClusterTunnel> Tunnels { get; set; } = [];

	/// <summary>
	/// List of Uplink settings of the device when uplink assignment mode of cluster is static
	/// </summary>
	[DataMember(Name = "uplinks")]
	public List<NetworksCampusGatewayClusterUplinkDetailed> Uplinks { get; set; } = [];
}