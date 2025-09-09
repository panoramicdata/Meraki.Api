namespace Meraki.Api.Data;

/// <summary>
/// The privilege of the dashboard administrator on the network. Can be one of 'full', 'read-only', 'guest-ambassador' or 'monitor-only'
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum AccessPrivilege
{
	/// <summary>
	/// Enum Allow for "allow"
	/// </summary>
	[EnumMember(Value = "full")]
	Full = 1,

	/// <summary>
	/// Enum Deny for "deny"
	/// </summary>
	[EnumMember(Value = "read-only")]
	ReadOnly,

	/// <summary>
	/// Enum Allow for "allow"
	/// </summary>
	[EnumMember(Value = "guest-ambassador")]
	GuestAmbassador,

	/// <summary>
	/// Enum Deny for "deny"
	/// </summary>
	[EnumMember(Value = "monitor-only")]
	MonitorOnly,

	/// <summary>
	/// Enum switchport - Not documented but apparently coming back in live data
	/// </summary>
	[EnumMember(Value = "switchport")]
	Switchport,

	/// <summary>
	/// Enum for "ssid-admin"
	/// </summary>
	[EnumMember(Value = "ssid-admin")]
	Ssidadmin,

	/// <summary>
	/// Enum for "port-tags"
	/// </summary>
	[EnumMember(Value = "port-tags")]
	Porttags,

	/// <summary>
	/// Enum for "custom-role"
	/// </summary>
	[EnumMember(Value = "custom-role")]
	Customrole
}
