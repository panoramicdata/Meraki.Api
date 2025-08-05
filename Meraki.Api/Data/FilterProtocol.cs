namespace Meraki.Api.Data;

/// <summary>
/// Filter Protocol
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum FilterProtocol
{
	/// <summary>
	/// Any
	/// </summary>
	[EnumMember(Value = "any")]
	Any,

	/// <summary>
	/// Icmp6
	/// </summary>
	[EnumMember(Value = "icmp6")]
	Icmp6,

	/// <summary>
	/// Tcp
	/// </summary>
	[EnumMember(Value = "tcp")]
	Tcp,

	/// <summary>
	/// Udp
	/// </summary>
	[EnumMember(Value = "udp")]
	Udp
}
