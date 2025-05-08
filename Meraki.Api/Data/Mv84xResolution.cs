namespace Meraki.Api.Data;

/// <summary>
/// Resolution of the camera.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum Mv84xResolution
{
	/// <summary>
	/// Enum 2560x1920
	/// </summary>
	[EnumMember(Value = "2560x1920")]
	Size2560x1920,

	/// <summary>
	/// Enum 1920x1080
	/// </summary>
	[EnumMember(Value = "1920x1080")]
	Size1920x1080
}
