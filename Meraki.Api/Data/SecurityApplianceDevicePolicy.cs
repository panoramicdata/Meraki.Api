namespace Meraki.Api.Data;

/// <summary>
/// The policy to apply to the specified client. Can be 'Whitelisted', 'Blocked' or 'Normal'. Required.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SecurityApplianceDevicePolicy
{
	/// <summary>
	/// Enum Whitelisted for "Whitelisted"
	/// </summary>
	[EnumMember(Value = "Whitelisted")]
	Whitelisted,

	/// <summary>
	/// Enum Blocked for "Blocked"
	/// </summary>
	[EnumMember(Value = "Blocked")]
	Blocked,

	/// <summary>
	/// Enum Normal for "Normal"
	/// </summary>
	[EnumMember(Value = "Normal")]
	Normal
}
