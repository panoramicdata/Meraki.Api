using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// L3FirewallRule
/// </summary>
[DataContract]
public class Layer3FirewallRule
{
	/// <summary>
	/// Description of the rule (optional)
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "comment")]
	public string? Comment { get; set; }

	/// <summary>
	/// 'allow' or 'deny' traffic specified by this rule
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "policy")]
	public string Policy { get; set; } = string.Empty;

	/// <summary>
	/// The type of protocol (must be 'tcp', 'udp', 'icmp' or 'any')
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "protocol")]
	public FirewallProtocol Protocol { get; set; }

	/// <summary>
	/// Destination port (integer in the range 1-65535), a port range (e.g. 8080-9090), or 'any'
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "destPort")]
	public string DestinationPort { get; set; } = string.Empty;

	/// <summary>
	/// Destination IP address (in IP or CIDR notation), a fully-qualified domain name (FQDN, if your network supports it) or 'any'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "destCidr")]
	public string DestinationCidr { get; set; } = string.Empty;
}
