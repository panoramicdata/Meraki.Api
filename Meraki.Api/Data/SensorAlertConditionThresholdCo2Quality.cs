namespace Meraki.Api.Data;

/// <summary>
/// Sensor Alert Condition Threshold Co2Quality
/// </summary>
[DataContract]
public enum SensorAlertConditionThresholdCo2Quality
{
	/// <summary>
	/// Fair
	/// </summary>
	[EnumMember(Value = "fair")]
	Fair,


	/// <summary>
	/// Good
	/// </summary>
	[EnumMember(Value = "good")]
	Good,


	/// <summary>
	/// Inadequate
	/// </summary>
	[EnumMember(Value = "inadequate")]
	Inadequate,


	/// <summary>
	/// Poor
	/// </summary>
	[EnumMember(Value = "poor")]
	Poor,
}
