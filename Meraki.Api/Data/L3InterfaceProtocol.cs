namespace Meraki.Api.Data;

/// <summary>
/// Optional parameter to filter L3 interfaces by protocol.enum = ["ipv4", "ipv6"]
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum L3InterfaceProtocol
{
	/// <summary>
	/// Enum Ipv4 for "ipv4"
	/// </summary>
	[EnumMember(Value = "ipv4")]
	Ipv4,

	/// <summary>
	/// Enum Ipv6 for "ipv6"
	/// </summary>
	[EnumMember(Value = "ipv6")]
	Ipv6
}
