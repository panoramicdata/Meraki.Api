namespace Meraki.Api.Data;

/// <summary>
/// Response from the CreateCampusGatewayClusterAsync endpoint.
/// </summary>
[DataContract]
public class NetworksCampusGatewayCluster
{
	/// <summary>
	/// ID of the cluster
	/// </summary>
	[ApiKey]
	[DataMember(Name = "clusterId")]
	[ApiAccess(ApiAccess.Read)]
	public string? ClusterId { get; set; }

	/// <summary>
	/// Name of the cluster
	/// </summary>
	[DataMember(Name = "name")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public string? Name { get; set; }

	/// <summary>
	/// Notes about the cluster
	/// </summary>
	[DataMember(Name = "notes")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public string? Notes { get; set; }

	/// <summary>
	/// URL to display cluster details
	/// </summary>
	[DataMember(Name = "url")]
	[ApiAccess(ApiAccess.Read)]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Nameservers of the cluster
	/// </summary>
	[DataMember(Name = "nameservers")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public NetworksCampusGatewayClusterNameservers? NameServers { get; set; }

	/// <summary>
	/// List of devices in the cluster
	/// </summary>
	[DataMember(Name = "devices")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public List<NetworksCampusGatewayClusterDeviceDetailed>? Devices { get; set; }

	/// <summary>
	/// List of Port Channel settings for the cluster
	/// </summary>
	[DataMember(Name = "portChannels")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public List<NetworksCampusGatewayClusterIdentifiedPortchannel>? PortChannels { get; set; }

	/// <summary>
	/// List of tunnel settings of the cluster
	/// </summary>
	[DataMember(Name = "tunnels")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public List<NetworksCampusGatewayClusterDeviceTunnelDetailed>? Tunnels { get; set; }

	/// <summary>
	/// List of uplink settings of the cluster
	/// </summary>
	[DataMember(Name = "uplinks")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public List<NetworksCampusGatewayClusterUplinkDetailed>? Uplinks { get; set; }
}
