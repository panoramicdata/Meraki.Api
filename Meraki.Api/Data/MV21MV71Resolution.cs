namespace Meraki.Api.Data;

/// <summary>
/// Resolution of the camera. Can be one of '1280x720', '1920x1080' or '2688x1512'.
/// </summary>
/// <value>Resolution of the camera. Can be one of '1280x720', '1920x1080' or '2688x1512'.</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum Mv21Mv71Resolution
{
	/// <summary>
	/// Enum 1280x720
	/// </summary>
	[EnumMember(Value = "1280x720")]
	Size1280x720,
}
