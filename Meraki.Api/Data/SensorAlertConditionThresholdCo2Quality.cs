namespace Meraki.Api.Data;

/// <summary>
/// Sensor Alert Condition Threshold Co2Quality
/// </summary>
[DataContract]
public enum SensorAlertConditionThresholdCo2Quality
{
	[EnumMember(Value = "fair")]
	Fair,

	[EnumMember(Value = "good")]
	Good,

	[EnumMember(Value = "inadequate")]
	Inadequate,

	[EnumMember(Value = "poor")]
	Poor,
}
