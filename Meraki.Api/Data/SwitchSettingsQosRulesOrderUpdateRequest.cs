using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkSwitchSettingsQosRulesOrder
	/// </summary>
	[DataContract]
	public partial class SwitchSettingsQosRulesOrderUpdateRequest
	{
		/// <summary>
		/// A list of quality of service rule IDs arranged in order in which they should be processed by the switch.
		/// </summary>
		/// <value>A list of quality of service rule IDs arranged in order in which they should be processed by the switch.</value>
		[DataMember(Name = "ruleIds", EmitDefaultValue = false)]
		public List<string> RuleIds { get; set; }
	}
}
