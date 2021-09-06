using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The firewall and traffic shaping rules and settings for your policy.
	/// </summary>
	[DataContract]
	public class FirewallAndTrafficShaping
	{
		/// <summary>
		/// Gets or Sets Settings
		/// </summary>
		[DataMember(Name = "settings", EmitDefaultValue = false)]
		public Setting Settings { get; set; }

		/// <summary>
		/// An array of traffic shaping rules. Rules are applied in the order that     they are specified in. An empty list (or null) means no rules. Note that     you are allowed a maximum of 8 rules.
		/// </summary>
		/// <value>An array of traffic shaping rules. Rules are applied in the order that     they are specified in. An empty list (or null) means no rules. Note that     you are allowed a maximum of 8 rules.</value>
		[DataMember(Name = "trafficShapingRules", EmitDefaultValue = false)]
		public List<TrafficShapingRule> TrafficShapingRules { get; set; } = null!;

		/// <summary>
		/// An ordered array of the L3 firewall rules
		/// </summary>
		/// <value>An ordered array of the L3 firewall rules</value>
		[DataMember(Name = "l3FirewallRules", EmitDefaultValue = false)]
		public List<Layer3FirewallRule> Layer3FirewallRules { get; set; } = null!;

		/// <summary>
		/// An ordered array of L7 firewall rules
		/// </summary>
		/// <value>An ordered array of L7 firewall rules</value>
		[DataMember(Name = "l7FirewallRules", EmitDefaultValue = false)]
		public List<Layer7FirewallRule> Layer7FirewallRules { get; set; } = null!;
	}
}
