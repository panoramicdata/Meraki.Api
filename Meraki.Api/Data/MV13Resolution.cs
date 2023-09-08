namespace Meraki.Api.Data;

/// <summary>
/// Resolution of the camera.
/// </summary>
/// <value>Resolution of the camera.</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum MV13Resolution
{
	/// <summary>
	/// Enum for "1080x1080"
	/// </summary>
	[EnumMember(Value = "1080x1080")]
	Size1080x1080,

	/// <summary>
	/// Enum 2688x1512
	/// </summary>
	[EnumMember(Value = "2688x1512")]
	Size2688x1512
}
