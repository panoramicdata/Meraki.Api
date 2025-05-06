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
	[ApiAccess(ApiAccess.CreateUpdate)]
	public string? ClusterId { get; set; }

	/// <summary>
	/// Name of the cluster
	/// </summary>
	[DataMember(Name = "name")]
	[ApiAccess(ApiAccess.CreateUpdate)]
	public string? Name { get; set; }

	/// <summary>
	/// Notes about the cluster
	/// </summary>
	[DataMember(Name = "notes")]
	[ApiAccess(ApiAccess.CreateUpdate)]
	public string? Notes { get; set; }

	/// <summary>
	/// URL to display cluster details
	/// </summary>
	[DataMember(Name = "url")]
	[ApiAccess(ApiAccess.CreateUpdate)]
	public string? Url { get; set; }

	/// <summary>
	/// Nameservers of the cluster
	/// </summary>
	[DataMember(Name = "nameservers")]
	[ApiAccess(ApiAccess.CreateUpdate)]
	public NetworksCampusGatewayClusterNameservers? NameServers { get; set; }

	/// <summary>
	/// List of devices in the cluster
	/// </summary>
	[DataMember(Name = "devices")]
	[ApiAccess(ApiAccess.CreateUpdate)]
	public List<NetworksCampusGatewayClusterDeviceDetailed>? Devices { get; set; }

	/// <summary>
	/// List of Port Channel settings for the cluster
	/// </summary>
	[DataMember(Name = "portChannels")]
	[ApiAccess(ApiAccess.CreateUpdate)]
	public List<NetworksCampusGatewayClusterIdentifiedPortchannel>? PortChannels { get; set; }

	/// <summary>
	/// List of tunnel settings of the cluster
	/// </summary>
	[DataMember(Name = "tunnels")]
	[ApiAccess(ApiAccess.CreateUpdate)]
	public List<NetworksCampusGatewayClusterDeviceTunnelDetailed>? Tunnels { get; set; }

	/// <summary>
	/// List of uplink settings of the cluster
	/// </summary>
	[DataMember(Name = "uplinks")]
	[ApiAccess(ApiAccess.CreateUpdate)]
	public List<NetworksCampusGatewayClusterUplinkDetailed>? Uplinks { get; set; }
}
