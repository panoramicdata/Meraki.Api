namespace Meraki.Api.Data;

/// <summary>
/// L 7 Firewall rules
/// </summary>
[DataContract]
public class SsidLayer7FirewallRules
{
	/// <summary>
	/// An array of L7 firewall rules for this SSID. Rules will get applied in the same order user has specified in request. Empty array will clear the L7 firewall rule configuration.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "rules")]
	public List<SsidLayer7FirewallRule> Rules { get; set; } = [];
}
