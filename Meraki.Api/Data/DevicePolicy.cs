namespace Meraki.Api.Data;

/// <summary>
/// The policy to apply to the specified client. Can be 'Group policy', 'Allowed', 'Blocked', 'Per connection' or 'Normal'. Required.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum DevicePolicy
{
	/// <summary>
	/// Group policy
	/// </summary>
	[EnumMember(Value = "Group policy")]
	GroupPolicy,

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

	/// <summary>
	/// Per connection
	/// </summary>
	[EnumMember(Value = "Per connection")]
	PerConnection,

	/// <summary>
	/// Normal
	/// </summary>
	[EnumMember(Value = "Normal")]
	Normal
}
