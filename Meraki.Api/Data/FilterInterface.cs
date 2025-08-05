namespace Meraki.Api.Data;

/// <summary>
/// Filter Interface
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum FilterInterface
{
	/// <summary>
	/// Wan1
	/// </summary>
	[EnumMember(Value = "")]
	Wan1,

	/// <summary>
	/// Wan2
	/// </summary>
	[EnumMember(Value = "")]
	Wan2
}