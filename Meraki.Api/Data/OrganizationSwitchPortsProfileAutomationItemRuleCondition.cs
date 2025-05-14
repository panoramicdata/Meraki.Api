namespace Meraki.Api.Data;

/// <summary>
/// Match type and criteria rule for target ports
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfileAutomationItemRuleCondition
{
	/// <summary>
	/// Match attribute/type for the given automaton rule
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "attribute")]
	public string Attribute { get; set; } = string.Empty;

	/// <summary>
	/// Match criteria/values for the given automaton rule
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "values")]
	public List<string> Values { get; set; } = [];
}