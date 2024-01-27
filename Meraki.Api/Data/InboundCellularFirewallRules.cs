namespace Meraki.Api.Data;

/// <summary>
/// NetworkInboundCellularFirewallRules
/// </summary>
[DataContract]
public class InboundCellularFirewallRules
{
	/// <summary>
	/// An ordered array of the firewall rules (not including the default rule)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "rules")]
	public List<MxFirewallRule> Rules { get; set; } = [];
}
