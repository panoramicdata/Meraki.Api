namespace Meraki.Api.Data;

/// <summary>
/// Resolution of the camera. Can be one of '1280x720', '1920x1080' or '2688x1512'.
/// </summary>
/// <value>Resolution of the camera. Can be one of '1280x720', '1920x1080' or '2688x1512'.</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum Mv22xMv72xResolution
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
	Size1920x1080,

	/// <summary>
	/// Enum _2688x1512 for "2688x1512"
	/// </summary>
	[EnumMember(Value = "2688x1512")]
	Size2688x1512
}
