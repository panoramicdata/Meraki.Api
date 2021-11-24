namespace Meraki.Api.Data;

/// <summary>
/// Firewall rules of an MX network
/// </summary>
[DataContract]
public class MxFirewallRule
{
	/// <summary>
	/// Description of the rule (optional)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "comment")]
	public string Comment { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets Policy
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "policy")]
	public AllowOrDeny Policy { get; set; }

	/// <summary>
	/// Gets or Sets Protocol
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "protocol")]
	public FirewallProtocol Protocol { get; set; }

	/// <summary>
	/// Comma-separated list of source port(s) (integer in the range 1-65535), or 'any'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "srcPort")]
	public string SourcePort { get; set; } = string.Empty;

	/// <summary>
	/// Comma-separated list of source IP address(es) (in IP or CIDR notation), or 'any' (note: FQDN not supported for source addresses)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "srcCidr")]
	public string SourceCidr { get; set; } = string.Empty;

	/// <summary>
	/// Comma-separated list of destination port(s) (integer in the range 1-65535), or 'any'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "destPort")]
	public string DestinationPort { get; set; } = string.Empty;

	/// <summary>
	/// Comma-separated list of destination IP address(es) (in IP or CIDR notation), fully-qualified domain names (FQDN) or 'any'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "destCidr")]
	public string DestinationCidr { get; set; } = string.Empty;

	/// <summary>
	/// Log this rule to syslog (true or false, boolean value) - only applicable if a syslog has been configured (optional)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "syslogEnabled")]
	public bool? SyslogEnabled { get; set; }
}
