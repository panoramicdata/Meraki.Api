namespace Meraki.Api.Data;

/// <summary>
/// The policy to apply to the specified client. Can be 'Allowed', 'Blocked', 'Normal' or 'Group policy'. Required.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SsidDevicePolicy
{
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

	/// <summary>
	/// Enum Normal for "Normal"
	/// </summary>
	[EnumMember(Value = "Normal")]
	Normal,

	/// <summary>
	/// Enum Grouppolicy for "Group policy"
	/// </summary>
	[EnumMember(Value = "Group policy")]
	GroupPolicy
}
