namespace Meraki.Api.Data;

/// <summary>
/// The firewall and traffic shaping rules and settings for your policy.
/// </summary>
[DataContract]
public class FirewallAndTrafficShaping
{
	/// <summary>
	/// Gets or Sets Settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "settings")]
	public Setting Settings { get; set; }

	/// <summary>
	/// An array of traffic shaping rules. Rules are applied in the order that they are specified in. An empty list (or null) means no rules. Note that     you are allowed a maximum of 8 rules.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "trafficShapingRules")]
	public List<TrafficShapingRule> TrafficShapingRules { get; set; } = new();

	/// <summary>
	/// An ordered array of the L3 firewall rules
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "l3FirewallRules")]
	public List<Layer3FirewallRule> Layer3FirewallRules { get; set; } = new();

	/// <summary>
	/// An ordered array of L7 firewall rules
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "l7FirewallRules")]
	public List<Layer7FirewallRule> Layer7FirewallRules { get; set; } = new();
}
