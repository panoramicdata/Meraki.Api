namespace Meraki.Api.Data;

/// <summary>
/// Rule10
/// </summary>
[DataContract]
public class SsidLayer3FirewallRule
{
	/// <summary>
	/// Description of the rule (optional)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "comment")]
	public string? Comment { get; set; }

	/// <summary>
	/// 'allow' or 'deny' traffic specified by this rule
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "policy")]
	public string Policy { get; set; } = string.Empty;

	/// <summary>
	/// The type of protocol (must be 'tcp', 'udp', 'icmp' or 'any')
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "protocol")]
	public FirewallProtocol Protocol { get; set; }

	/// <summary>
	/// Destination port (integer in the range 1-65535), a port range (e.g. 8080-9090), or 'any'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "destPort")]
	public string DestinationPort { get; set; } = string.Empty;

	/// <summary>
	/// Destination IP address (in IP or CIDR notation), a fully-qualified domain name (FQDN, if your network supports it) or 'any'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "destCidr")]
	public string DestinationCidr { get; set; } = string.Empty;

	/// <summary>
	/// Undocumented IP Version - Observed values so far: 'ipv4'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ipVer")]
	public string? IpVer { get; set; }
}
