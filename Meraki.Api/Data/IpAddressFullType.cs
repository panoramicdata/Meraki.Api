namespace Meraki.Api.Data;

/// <summary>
/// Ip AddressType
/// <list type="bullet">
/// <item>FQDN</item>
/// <item>Ipv4</item>
/// <item>Ipv6</item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum IpAddressFullType
{
	/// <summary>
	/// Fqdn
	/// </summary>
	[EnumMember(Value = "fqdn")]
	Fqdn,

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