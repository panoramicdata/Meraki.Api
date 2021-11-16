namespace Meraki.Api.Data;

/// <summary>
/// CellularGatewayPortForwardingRule
/// </summary>
[DataContract]
public class CellularGatewayPortForwardingRule
{
	/// <summary>
	/// A descriptive name for the rule
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The IP address of the server or device that hosts the internal resource that you wish to make available on the WAN
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "lanIp")]
	public string LanIp { get; set; } = string.Empty;

	/// <summary>
	/// A port or port ranges that will be forwarded to the host on the LAN
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "publicPort")]
	public string PublicPort { get; set; } = string.Empty;

	/// <summary>
	/// A port or port ranges that will receive the forwarded traffic from the WAN
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "localPort")]
	public string LocalPort { get; set; } = string.Empty;

	/// <summary>
	/// An array of ranges of WAN IP addresses that are allowed to make inbound connections on the specified ports or port ranges.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "allowedIps")]
	public List<string> AllowedIps { get; set; } = new();

	/// <summary>
	/// TCP or UDP
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "protocol")]
	public string Protocol { get; set; } = string.Empty;

	/// <summary>
	/// `any` or `restricted`. Specify the right to make inbound connections on the specified ports or port ranges. If `restricted`, a list of allowed IPs is mandatory.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "access")]
	public string Access { get; set; } = string.Empty;
}
