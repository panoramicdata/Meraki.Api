namespace Meraki.Api.Data;

/// <summary>
/// Minimum bitrate can be set to either 'band' or 'ssid'. Defaults to band.
/// </summary>
/// <value>Minimum bitrate can be set to either 'band' or 'ssid'. Defaults to band.</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum MinBitrateType
{
	/// <summary>
	/// Enum Band for "band"
	/// </summary>
	[EnumMember(Value = "band")]
	Band,

	/// <summary>
	/// Enum Ssid for "ssid"
	/// </summary>
	[EnumMember(Value = "ssid")]
	Ssid
}
