using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkTrafficShaping
	/// </summary>
	[DataContract]
	public partial class TrafficShapingUpdateRequest
	{
		/// <summary>
		/// Whether default traffic shaping rules are enabled (true) or disabled (false).     There are 4 default rules, which can     be seen on your network&#39;s traffic shaping page. Note that default rules     count against the rule limit of 8.
		/// </summary>
		/// <value>Whether default traffic shaping rules are enabled (true) or disabled (false).     There are 4 default rules, which can     be seen on your network&#39;s traffic shaping page. Note that default rules     count against the rule limit of 8.</value>
		[DataMember(Name = "defaultRulesEnabled", EmitDefaultValue = false)]
		public bool? DefaultRulesEnabled { get; set; }

		/// <summary>
		/// An array of traffic shaping rules. Rules are applied in the order that     they are specified in. An empty list (or null) means no rules. Note that     you are allowed a maximum of 8 rules.
		/// </summary>
		/// <value>An array of traffic shaping rules. Rules are applied in the order that     they are specified in. An empty list (or null) means no rules. Note that     you are allowed a maximum of 8 rules.</value>
		[DataMember(Name = "rules", EmitDefaultValue = false)]
		public List<TrafficShapingRule> Rules { get; set; } = null!;
	}
}
