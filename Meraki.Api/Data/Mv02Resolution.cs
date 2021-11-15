namespace Meraki.Api.Data;

/// <summary>
/// Resolution of the camera. Can be one of '1280x720' or '1920x1080'.
/// </summary>
/// <value>Resolution of the camera. Can be one of '1280x720' or '1920x1080'.</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum Mv02Resolution
{
	/// <summary>
	/// Enum _1280x720 for "1280x720"
	/// </summary>
	[EnumMember(Value = "1280x720")]
	Size1280x720,

	/// <summary>
	/// Enum _1920x1080 for "1920x1080"
	/// </summary>
	[EnumMember(Value = "1920x1080")]
	Size1920x1080
}
