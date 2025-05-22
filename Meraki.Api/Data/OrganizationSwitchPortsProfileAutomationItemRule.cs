namespace Meraki.Api.Data;

/// <summary>
/// Automation rules configurations
/// </summary>
[DataContract]
public class OrganizationSwitchPortsProfileAutomationItemRule
{
	/// <summary>
	/// Automation sequence
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "priority")]
	public int Priority { get; set; }

	/// <summary>
	/// Profile to be applied
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "profile")]
	public OrganizationSwitchPortsProfileAutomationItemRuleProfile Profile { get; set; } = new();

	/// <summary>
	/// Match type and criteria rule for target ports
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "conditions")]
	public List<OrganizationSwitchPortsProfileAutomationItemRuleCondition> Conditions { get; set; } = [];
}
