namespace Meraki.Api.Data;

/// <summary>
/// Resolution of the camera. Resolution of the camera. Can be one of '1920x1080', '2688x1512' or '3840x2160'.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum Mv73Resolution
{
	/// <summary>
	/// Enum _1920x1080
	/// </summary>
	[EnumMember(Value = "1920x1080")]
	Size1920x1080,

	/// <summary>
	/// Enum _2688x1512
	/// </summary>
	[EnumMember(Value = "2688x1512")]
	Size2688x1512,

	/// <summary>
	/// Enum _3840x2160
	/// </summary>
	[EnumMember(Value = "3840x2160")]
	Size3840x2160
}
