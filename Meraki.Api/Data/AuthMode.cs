namespace Meraki.Api.Data;

/// <summary>
/// The association control method for the SSID ('open', 'open-enhanced', 'psk', 'open-with-radius', 'open-with-nac', '8021x-meraki', '8021x-nac', '8021x-radius', '8021x-google', '8021x-localradius', 'ipsk-with-radius' or 'ipsk-without-radius')
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum AuthMode
{
	/// <summary>
	/// Open
	/// </summary>
	[EnumMember(Value = "open")]
	Open,

	/// <summary>
	/// OpenEnhanced
	/// </summary>
	[EnumMember(Value = "open-enhanced")]
	OpenEnhanced,

	/// <summary>
	/// PSK
	/// </summary>
	[EnumMember(Value = "psk")]
	Psk,

	/// <summary>
	/// Open with RADIUS
	/// </summary>
	[EnumMember(Value = "open-with-radius")]
	OpenWithRadius,

	/// <summary>
	/// Open with NAC
	/// </summary>
	[EnumMember(Value = "open-with-nac")]
	OpenWithNac,

	/// <summary>
	/// 8021x Meraki
	/// </summary>
	[EnumMember(Value = "8021x-meraki")]
	Auth8021xMeraki,

	/// <summary>
	/// 8021x NAC
	/// </summary>
	[EnumMember(Value = "8021x-nac")]
	Auth8021xNac,

	/// <summary>
	/// 8021x RADIUS
	/// </summary>
	[EnumMember(Value = "8021x-radius")]
	Auth8021xRadius,

	/// <summary>
	/// 8021x Google
	/// </summary>
	[EnumMember(Value = "8021x-google")]
	Auth8021xGoogle,

	/// <summary>
	/// 8021x Local RADIUS
	/// </summary>
	[EnumMember(Value = "8021x-localradius")]
	Auth8021xLocalRadius,
	/// <summary>
	/// IPSK with RADIUS
	/// </summary>
	[EnumMember(Value = "ipsk-with-radius")]
	IpskWithRadius,

	/// <summary>
	/// IPSK without RADIUS
	/// </summary>
	[EnumMember(Value = "ipsk-without-radius")]
	IpskWithoutRadius,

	/// <summary>
	/// IPSK with NAC
	/// </summary>
	[EnumMember(Value = "ipsk-with-nac")]
	IpskWithNac
}
