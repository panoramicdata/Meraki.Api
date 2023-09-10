namespace Meraki.Api.Data;

/// <summary>
/// The psk encryption mode for the SSID ('wep' or 'wpa'). This param is only valid if the authMode is 'psk'
/// </summary>
/// <value>The psk encryption mode for the SSID ('wep' or 'wpa'). This param is only valid if the authMode is 'psk'</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum EncryptionMode
{
	/// <summary>
	/// Enum Wep for "wep"
	/// </summary>
	[EnumMember(Value = "wep")]
	Wep,

	/// <summary>
	/// Enum Wpa for "wpa"
	/// </summary>
	[EnumMember(Value = "wpa")]
	Wpa,

	/// <summary>
	/// Enum WpaEap for "wpa-eap"
	/// </summary>
	[EnumMember(Value = "wpa-eap")]
	WpaEap,

	/// <summary>
	/// Open
	/// </summary>
	[EnumMember(Value = "open")]
	Open
}