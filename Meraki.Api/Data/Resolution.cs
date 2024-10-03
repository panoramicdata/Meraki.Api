namespace Meraki.Api.Data;

/// <summary>
/// Resolution of the camera. Not all resolutions are supported by every camera model.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum Resolution
{
	/// <summary>
	/// Enum for "1280x720"
	/// </summary>
	[EnumMember(Value = "1280x720")]
	Size1280x720,

	/// <summary>
	/// Enum for "1920x1080"
	/// </summary>
	[EnumMember(Value = "1920x1080")]
	Size1920x1080,

	/// <summary>
	/// Enum for "1080x1080"
	/// </summary>
	[EnumMember(Value = "1080x1080")]
	Size1080x1080,

	/// <summary>
	/// Enum for "2058x2058"
	/// </summary>
	[EnumMember(Value = "2058x2058")]
	Size2058x2058,

	/// <summary>
	/// Enum for "2112x2112"
	/// </summary>
	[EnumMember(Value = "2112x2112")]
	Size2112x2112,

	/// <summary>
	/// Enum for "2688x1512"
	/// </summary>
	[EnumMember(Value = "2688x1512")]
	Size2688x1512,

	/// <summary>
	/// Enum for "2880x2880"
	/// </summary>
	[EnumMember(Value = "2880x2880")]
	Size2880x2880
}
