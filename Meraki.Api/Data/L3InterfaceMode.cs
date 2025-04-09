namespace Meraki.Api.Data;

/// <summary>
/// Optional parameter to filter L3 interfaces by mode. enum = ["loopback", "routed", "vlan"]
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum L3InterfaceMode
{
	/// <summary>
	/// Enum Loopback for "loopback"
	/// </summary>
	[EnumMember(Value = "loopback")]
	Loopback,

	/// <summary>
	/// Enum Routed for "routed"
	/// </summary>
	[EnumMember(Value = "routed")]
	Routed,

	/// <summary>
	/// Enum Vlan for "vlan"
	/// </summary>
	[EnumMember(Value = "vlan")]
	Vlan
}
