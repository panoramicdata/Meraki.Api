namespace Meraki.Api.Data;

/// <summary>
/// Response from the CreateCampusGatewayClusterAsync endpoint.
/// </summary>
[DataContract]
public class NetworksCampusGatewayClusterResponse
{
	/// <summary>
	/// ID of the cluster
	/// </summary>
	[DataMember(Name = "clusterId")]
	public string? ClusterId { get; set; }

	/// <summary>
	/// Name of the cluster
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// Notes about the cluster
	/// </summary>
	[DataMember(Name = "notes")]
	public string? Notes { get; set; }

	/// <summary>
	/// URL to display cluster details
	/// </summary>
	[DataMember(Name = "url")]
	public string? Url { get; set; }

	/// <summary>
	/// Nameservers of the cluster
	/// </summary>
	[DataMember(Name = "nameservers")]
	public NetworksCampusGatewayClusterNameservers? NameServers { get; set; }

	/// <summary>
	/// List of devices in the cluster
	/// </summary>
	[DataMember(Name = "devices")]
	public List<NetworksCampusGatewayClusterDeviceDetailed>? Devices { get; set; }

	/// <summary>
	/// List of Port Channel settings for the cluster
	/// </summary>
	[DataMember(Name = "portChannels")]
	public List<NetworksCampusGatewayClusterIdentifiedPortchannel>? PortChannels { get; set; }

	/// <summary>
	/// List of tunnel settings of the cluster
	/// </summary>
	[DataMember(Name = "tunnels")]
	public List<NetworksCampusGatewayClusterDeviceTunnelDetailed>? Tunnels { get; set; }

	/// <summary>
	/// List of uplink settings of the cluster
	/// </summary>
	public List<NetworksCampusGatewayClusterUplinkDetailed>? Uplinks { get; set; }
}
