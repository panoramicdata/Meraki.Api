namespace Meraki.Api.Data;

/// <summary>
/// Band selection can be set to either 'ssid' or 'ap'. This param is required on creation.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum BandSelectionType
{
	/// <summary>
	/// Enum Ssid for "ssid"
	/// </summary>
	[EnumMember(Value = "ssid")]
	Ssid,

	/// <summary>
	/// Enum Ap for "ap"
	/// </summary>
	[EnumMember(Value = "ap")]
	Ap
}
