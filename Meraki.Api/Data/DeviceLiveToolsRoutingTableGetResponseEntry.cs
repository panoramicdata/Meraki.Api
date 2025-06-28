namespace Meraki.Api.Data;

/// <summary>
/// Routing table entry
/// </summary>
[DataContract]
public class DeviceLiveToolsRoutingTableGetResponseEntry
{
	/// <summary>
	/// The IP version of the route. enum = ["ipv4", "ipv6"]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ipVersion")]
	public string IpVersion { get; set; } = string.Empty;

	/// <summary>
	/// The static gateway IP address of the route, if the type is "static" or "ospf"
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "staticGateway")]
	public string StaticGateway { get; set; } = string.Empty;

	/// <summary>
	/// The subnet of the route in CIDR format
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "subnet")]
	public string Subnet { get; set; } = string.Empty;

	/// <summary>
	/// The type of route defined. enum = ["anycon_vpn", "client_vpn", "ipsec_vpn", "l3_vpn", "local_uplink", ...]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;
}