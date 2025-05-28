namespace Meraki.Api.Data;

/// <summary>
/// Uplink Interface
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum UplinkInterface
{
	/// <summary>
	/// Cellular
	/// </summary>
	[EnumMember(Value = "cellular")]
	Cellular,

	/// <summary>
	/// Man 1
	/// </summary>
	[EnumMember(Value = "man1")]
	Man1,

	/// <summary>
	/// Man 2
	/// </summary>
	[EnumMember(Value = "man2")]
	Man2,

	/// <summary>
	/// Wan 1
	/// </summary>
	[EnumMember(Value = "wan1")]
	Wan1,

	/// <summary>
	/// Wan 2
	/// </summary>
	[EnumMember(Value = "wan2")]
	Wan2
}