namespace Meraki.Api.Data;

/// <summary>
/// The type of SNMP access. Can be one of 'none' (disabled), 'community' (V1/V2c), or 'users' (V3).
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SnmpAccess
{
	/// <summary>
	/// Enum None for "none"
	/// </summary>
	[EnumMember(Value = "none")]
	None,

	/// <summary>
	/// Enum Community for "community"
	/// </summary>
	[EnumMember(Value = "community")]
	Community,

	/// <summary>
	/// Enum Users for "users"
	/// </summary>
	[EnumMember(Value = "users")]
	Users
}
