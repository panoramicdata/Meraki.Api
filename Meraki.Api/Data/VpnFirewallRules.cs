namespace Meraki.Api.Data;

/// <summary>
/// UpdateOrganizationVpnFirewallRules
/// </summary>
[DataContract]
public class VpnFirewallRules
{
	/// <summary>
	/// An ordered array of the firewall rules (not including the default rule)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "rules")]
	public List<VpnFirewallRule> Rules { get; set; } = new();

	/// <summary>
	/// Log the special default rule (boolean value - enable only if you've configured a syslog server) (optional)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "syslogDefaultRule")]
	public bool? SyslogDefaultRule { get; set; }
}
