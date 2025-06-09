namespace Meraki.Api.Data;

/// <summary>
/// Tunnel setting of the device
/// </summary>
[DataContract]
public class OrganizationCampusGatewayClusterDeviceTunnel
{
	/// <summary>
	/// Tunnel interface name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "interface")]
	public string Interface { get; set; } = string.Empty;

	/// <summary>
	/// Tunnel IP addresses of the device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "addresses")]
	public List<OrganizationCampusGatewayClusterDeviceTunnelAddress> Addresses { get; set; } = [];
}
