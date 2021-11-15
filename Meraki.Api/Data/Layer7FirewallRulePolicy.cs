namespace Meraki.Api.Data;

/// <summary>
/// The policy applied to matching traffic. Must be 'deny'.
/// </summary>
/// <value>The policy applied to matching traffic. Must be 'deny'.</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum Layer7FirewallRulePolicy
{
	/// <summary>
	/// Enum Deny for "deny"
	/// </summary>
	[EnumMember(Value = "deny")]
	Deny
}
