namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkL3FirewallRules
/// </summary>
[DataContract]
public class Layer3FirewallRules
{
	/// <summary>
	/// An ordered array of the firewall rules (not including the default rule)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "rules")]
	public List<MxFirewallRule> Rules { get; set; } = new();

	/// <summary>
	/// Log the special default rule (boolean value - enable only if you've configured a syslog server) (optional)
	/// </summary>
	[ApiAccess(ApiAccess.Update)]
	[DataMember(Name = "syslogDefaultRule")]
	public bool? SyslogDefaultRule { get; set; }
}
