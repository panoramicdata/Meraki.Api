namespace Meraki.Api.Data;

/// <summary>
/// Organization Campus Gateway Cluster
/// </summary>
[DataContract]
public class OrganizationCampusGatewayCluster
{
	/// <summary>
	/// ID of the cluster
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "clusterId")]
	public string ClusterId { get; set; } = string.Empty;

	/// <summary>
	/// Name of the cluster
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Notes about cluster
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "notes")]
	public string Notes { get; set; } = string.Empty;

	/// <summary>
	/// URL to display cluster details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "url")]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// Nameservers of the cluster
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "nameservers")]
	public OrganizationCampusGatewayClusterNameservers Nameservers { get; set; } = new();

	/// <summary>
	/// Network details of the cluster
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "network")]
	public OrganizationCampusGatewayClusterNetwork Network { get; set; } = new();

	/// <summary>
	/// Devices in the cluster
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "devices")]
	public List<OrganizationCampusGatewayClusterDevice> Devices { get; set; } = [];

	/// <summary>
	/// Port channel settings of the cluster
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "portChannels")]
	public List<OrganizationCampusGatewayClusterPortChannel> PortChannels { get; set; } = [];

	/// <summary>
	/// Tunnel settings of the cluster
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tunnels")]
	public List<OrganizationCampusGatewayClusterTunnel> Tunnels { get; set; } = [];

	/// <summary>
	/// Uplink settings of the cluster
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "uplinks")]
	public List<OrganizationCampusGatewayClusterUplink> Uplinks { get; set; } = [];
}
