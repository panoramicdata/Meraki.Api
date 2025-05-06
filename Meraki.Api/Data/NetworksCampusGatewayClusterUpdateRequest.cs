namespace Meraki.Api.Data;

/// <summary>
/// Networks Campus Gateway Cluster Update Request
/// </summary>
[DataContract]
public class NetworksCampusGatewayClusterUpdateRequest
{
	/// <summary>
	/// Name of the cluster
	/// </summary>
	[DataMember(Name = "name")]
	[ApiAccess(ApiAccess.Update)]
	public string? Name { get; set; }

	/// <summary>
	/// Notes about cluster with max size of 511 characters allowed
	/// </summary>
	[DataMember(Name = "notes")]
	[ApiAccess(ApiAccess.Update)]
	public string? Notes { get; set; }

	/// <summary>
	/// Nameservers of the cluster
	/// </summary>
	[DataMember(Name = "nameservers")]
	[ApiAccess(ApiAccess.Update)]
	public NetworksCampusGatewayClusterUpdateRequestNameServers? Nameservers { get; set; }

	/// <summary>
	/// Devices in the cluster
	/// </summary>
	[DataMember(Name = "devices")]
	[ApiAccess(ApiAccess.Update)]
	public List<NetworksCampusGatewayClusterUpdateRequestDevice>? Devices { get; set; }

	/// <summary>
	/// Port channel settings of the cluster
	/// </summary>
	[DataMember(Name = "portChannels")]
	[ApiAccess(ApiAccess.Update)]
	public List<NetworksCampusGatewayClusterUpdateRequestPortChannel>? PortChannels { get; set; }

	/// <summary>
	/// Tunnel interface settings of the cluster: Reuse uplink or specify tunnel interface
	/// </summary>
	[DataMember(Name = "tunnels")]
	[ApiAccess(ApiAccess.Update)]
	public List<NetworksCampusGatewayClusterUpdateRequestTunnel>? Tunnels { get; set; }

	/// <summary>
	/// Uplink interface settings of the cluster
	/// </summary>
	[DataMember(Name = "uplinks")]
	[ApiAccess(ApiAccess.Update)]
	public List<NetworksCampusGatewayClusterUpdateRequestUplink>? Uplinks { get; set; }
}
