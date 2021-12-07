namespace Meraki.Api.Data;

[JsonConverter(typeof(StringEnumConverter))]
public enum GroupPolicyDevicePolicy
{
	/// <summary>
	/// Enum Grouppolicy for "Group policy"
	/// </summary>
	[EnumMember(Value = "Group policy")]
	Grouppolicy,

	/// <summary>
	/// Enum Allowed for "Allowed"
	/// </summary>
	[EnumMember(Value = "Allowed")]
	Allowed,

	/// <summary>
	/// Enum Blocked for "Blocked"
	/// </summary>
	[EnumMember(Value = "Blocked")]
	Blocked,
}