namespace Meraki.Api.Data;

/// <summary>
/// Tunnel setting of the cluster
/// </summary>
[DataContract]
public class OrganizationCampusGatewayClusterTunnel
{
	/// <summary>
	/// VLAN ID of the interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "vlan")]
	public int Vlan { get; set; }

	/// <summary>
	/// Name of the interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "interface")]
	public string Interface { get; set; } = string.Empty;

	/// <summary>
	/// Use uplink interface as tunnel interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "uplink")]
	public OrganizationCampusGatewayClusterTunnelUplink Uplink { get; set; } = new();

	/// <summary>
	/// Addresses of the interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "addresses")]
	public List<OrganizationCampusGatewayClusterTunnelAddress> Addresses { get; set; } = [];
}
