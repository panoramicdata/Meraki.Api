namespace Meraki.Api.Data;

/// <summary>
/// Resolution of the camera.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum Mv93Resolution
{
	/// <summary>
	/// Enum 2880x2880
	/// </summary>
	[EnumMember(Value = "2880x2880")]
	Size2880x2880,

	/// <summary>
	/// Enum 2112x2112
	/// </summary>
	[EnumMember(Value = "2112x2112")]
	Size2112x2112,

	/// <summary>
	/// Enum 1080x1080
	/// </summary>
	[EnumMember(Value = "1080x1080")]
	Size1080x1080
}
