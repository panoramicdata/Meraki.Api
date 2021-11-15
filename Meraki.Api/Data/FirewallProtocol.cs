namespace Meraki.Api.Data;

/// <summary>
/// The type of protocol (must be 'tcp', 'udp', 'icmp' or 'any')
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum FirewallProtocol
{
	/// <summary>
	/// Enum Tcp for "tcp"
	/// </summary>
	[EnumMember(Value = "tcp")]
	Tcp = 1,

	/// <summary>
	/// Enum Udp for "udp"
	/// </summary>
	[EnumMember(Value = "udp")]
	Udp,

	/// <summary>
	/// Enum Icmp for "icmp"
	/// </summary>
	[EnumMember(Value = "icmp")]
	Icmp,

	/// <summary>
	/// Enum Any for "any"
	/// </summary>
	[EnumMember(Value = "any")]
	Any
}
