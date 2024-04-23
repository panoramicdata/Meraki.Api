namespace Meraki.Api.Data;

/// <summary>
/// Sensor Alert Condition Direction
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SensorAlertConditionDirection
{
	/// <summary>
	/// above
	/// </summary>
	[EnumMember(Value = "above")]
	Above,

	/// <summary>
	/// below
	/// </summary>
	[EnumMember(Value = "below")]
	Below
}