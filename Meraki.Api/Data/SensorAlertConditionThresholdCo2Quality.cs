namespace Meraki.Api.Data;

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