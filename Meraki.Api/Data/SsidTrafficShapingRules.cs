namespace Meraki.Api.Data;

/// <summary>
/// The traffic shaping settings for an SSID on an MR network
/// </summary>
[DataContract]
public class SsidTrafficShapingRules
{
	/// <summary>
	/// Whether traffic shaping rules are applied to clients on your SSID.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "trafficShapingEnabled")]
	public bool? TrafficShapingEnabled { get; set; }

	/// <summary>
	/// Whether default traffic shaping rules are enabled (true) or disabled (false). There are 4 default rules, which can be seen on your network's traffic shaping page. Note that default rules     count against the rule limit of 8.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "defaultRulesEnabled")]
	public bool? DefaultRulesEnabled { get; set; }

	/// <summary>
	/// An array of traffic shaping rules. Rules are applied in the order that they are specified in. An empty list (or null) means no rules. Note that     you are allowed a maximum of 8 rules.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "rules")]
	public List<SsidTrafficShapingRule> Rules { get; set; } = null!;
}
