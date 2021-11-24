namespace Meraki.Api.Data;

/// <summary>
/// PortRule
/// </summary>
[DataContract]
public class PortRule
{
	/// <summary>
	/// A description of the rule
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Protocol
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "protocol")]
	public TcpUdpProtocol Protocol { get; set; }

	/// <summary>
	/// Destination port of the traffic that is arriving on the WAN
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "publicPort")]
	public string PublicPort { get; set; } = string.Empty;

	/// <summary>
	/// Local IP address to which traffic will be forwarded
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "localIp")]
	public string LocalIp { get; set; } = string.Empty;

	/// <summary>
	/// Destination port of the forwarded traffic that will be sent from the MX to the specified host on the LAN. If you simply wish to forward the traffic without translating the port, this should be the same as the Public port
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "localPort")]
	public string LocalPort { get; set; } = string.Empty;

	/// <summary>
	/// Remote IP addresses or ranges that are permitted to access the internal resource via this port forwarding rule, or 'any'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "allowedIps")]
	public List<string> AllowedIps { get; set; } = new();
}
