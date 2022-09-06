namespace Meraki.Api.Data;

/// <summary>
/// The association control method for the SSID ('open', 'psk', 'open-with-radius', '8021x-meraki', '8021x-radius', 'ipsk-with-radius' or 'ipsk-without-radius')
/// </summary>
/// <value>The association control method for the SSID ('open', 'psk', 'open-with-radius', '8021x-meraki', '8021x-radius', 'ipsk-with-radius' or 'ipsk-without-radius')</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum AuthMode
{
	/// <summary>
	/// Open
	/// </summary>
	[EnumMember(Value = "open")]
	Open,

	/// <summary>
	/// PSK
	/// </summary>
	[EnumMember(Value = "psk")]
	Psk,

	/// <summary>
	/// Open with RADIUS
	/// </summary>
	[EnumMember(Value = "open-with-radius")]
	Openwithradius,

	/// <summary>
	/// 8021x Meraki
	/// </summary>
	[EnumMember(Value = "8021x-meraki")]
	Auth8021xmeraki,

	/// <summary>
	/// 8021x RADIUS
	/// </summary>
	[EnumMember(Value = "8021x-radius")]
	Auth8021xradius,

	/// <summary>
	/// IPSK with RADIUS
	/// </summary>
	[EnumMember(Value = "ipsk-with-radius")]
	Ipskwithradius,

	/// <summary>
	/// IPSK without RADIUS
	/// </summary>
	[EnumMember(Value = "ipsk-without-radius")]
	Ipskwithoutradius
}
