namespace Meraki.Api.Data;

/// <summary>
/// Resolution of the camera. Can be one of '1080x1080' or '2058x2058'.
/// </summary>
/// <value>Resolution of the camera. Can be one of '1080x1080' or '2058x2058'.</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum Mv32Resolution
{
	/// <summary>
	/// Enum _1080x1080 for "1080x1080"
	/// </summary>
	[EnumMember(Value = "1080x1080")]
	Size1080x1080,

	/// <summary>
	/// Enum _2112x2112 for "2112x2112"
	/// </summary>
	[EnumMember(Value = "2112x2112")]
	Size2112x2112,

	/// <summary>
	/// Enum _2058x2058 for "2058x2058"
	/// </summary>
	[EnumMember(Value = "2058x2058")]
	Size2058x2058
}
