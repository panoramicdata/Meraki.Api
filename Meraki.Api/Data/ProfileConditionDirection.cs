namespace Meraki.Api.Data;

/// <summary>
/// Profile Condition Direction
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ProfileConditionDirection
{
	/// <summary>
	/// Above
	/// </summary>
	[EnumMember(Value = "above")]
	Above,
	/// <summary>
	/// Below
	/// </summary>
	[EnumMember(Value = "below")]
	Below
}