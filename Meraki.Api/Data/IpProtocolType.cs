namespace Meraki.Api.Data;

/// <summary>
/// The IP protocol used for the address
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum IpProtocolType
{
	/// <summary>
	/// IPv4
	/// </summary>
	[EnumMember(Value = "ipv4")]
	Ipv4,

	/// <summary>
	/// IPv6
	/// </summary>
	[EnumMember(Value = "ipv6")]
	Ipv6
}