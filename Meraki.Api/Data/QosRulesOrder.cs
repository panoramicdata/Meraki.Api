using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkSwitchSettingsQosRulesOrder
/// </summary>
[DataContract]
public class QosRulesOrder
{
	/// <summary>
	/// A list of quality of service rule IDs arranged in order in which they should be processed by the switch.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ruleIds")]
	public List<string> RuleIds { get; set; } = new();
}
