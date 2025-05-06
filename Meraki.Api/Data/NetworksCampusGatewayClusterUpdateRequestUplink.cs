namespace Meraki.Api.Data;

/// <summary>
/// Uplink interface setting of the cluster
/// </summary>
[DataContract]
public class NetworksCampusGatewayClusterUpdateRequestUplink
{
	/// <summary>
	/// VLAN ID of the interface
	/// </summary>
	[DataMember(Name = "vlan")]
	[ApiAccess(ApiAccess.Update)]
	public int? Vlan { get; set; }

	/// <summary>
	/// Interface identifier, should be set to man1
	/// </summary>
	[DataMember(Name = "interface")]
	[ApiAccess(ApiAccess.Update)]
	public string? Interface { get; set; }

	/// <summary>
	/// Addresses of the interface
	/// </summary>
	[DataMember(Name = "addresses")]
	[ApiAccess(ApiAccess.Update)]
	public List<NetworksCampusGatewayClusterUpdateRequestUplinkAddress>? Addresses { get; set; }
}
