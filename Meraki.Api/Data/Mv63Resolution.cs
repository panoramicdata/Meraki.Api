namespace Meraki.Api.Data;

/// <summary>
/// Resolution of the camera.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum Mv63Resolution
{
	/// <summary>
	/// Enum 1960x1080
	/// </summary>
	[EnumMember(Value = "1960x1080")]
	Size1960x1080,

	/// <summary>
	/// Enum 2560x1440
	/// </summary>
	[EnumMember(Value = "2560x1440")]
	Size2560x1440,

	/// <summary>
	/// Enum 3840x2160
	/// </summary>
	[EnumMember(Value = "3840x2160")]
	Size3840x2160
}
