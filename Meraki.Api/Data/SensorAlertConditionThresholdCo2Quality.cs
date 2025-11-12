namespace Meraki.Api.Data;

/// <summary>
/// Sensor Alert Condition Threshold Co2Quality
/// </summary>
[DataContract]
public enum SensorAlertConditionThresholdCo2Quality
{
	[EnumMember(Value = "fair")]
	/// <summary>
	/// Fair
	/// </summary>
	Fair,

	[EnumMember(Value = "good")]
	/// <summary>
	/// Good
	/// </summary>
	Good,

	[EnumMember(Value = "inadequate")]
	/// <summary>
	/// Inadequate
	/// </summary>
	Inadequate,

	[EnumMember(Value = "poor")]
	/// <summary>
	/// Poor
	/// </summary>
	Poor,
}
