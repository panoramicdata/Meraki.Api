namespace Meraki.Api.Data;

/// <summary>
/// Group Policy Device Policy
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum GroupPolicyDevicePolicy
{
	/// <summary>
	/// Group policy
	/// </summary>
	[EnumMember(Value = "Group policy")]
	Grouppolicy,

	/// <summary>
	/// Allowed
	/// </summary>
	[EnumMember(Value = "Allowed")]
	Allowed,

	/// <summary>
	/// Blocked
	/// </summary>
	[EnumMember(Value = "Blocked")]
	Blocked,
}
