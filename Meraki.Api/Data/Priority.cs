namespace Meraki.Api.Data;

[JsonConverter(typeof(StringEnumConverter))]
public enum Priority
{
	/// <summary>
	/// Enum Low for "low"
	/// </summary>
	[EnumMember(Value = "low")]
	Low,

	/// <summary>
	/// Enum Normal for "normal"
	/// </summary>
	[EnumMember(Value = "normal")]
	Normal,

	/// <summary>
	/// Enum High for "high"
	/// </summary>
	[EnumMember(Value = "high")]
	High
}