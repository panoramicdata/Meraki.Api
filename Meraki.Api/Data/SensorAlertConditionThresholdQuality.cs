namespace Meraki.Api.Data;

/// <summary>
/// Quality settings alert condition profile thresholds
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]

public enum SensorAlertConditionThresholdQuality
{
	/// <summary>
	/// inadequate
	/// </summary>
	[EnumMember(Value = "inadequate")]
	Inadequate,

	/// <summary>
	/// poor
	/// </summary>
	[EnumMember(Value = "poor")]
	Poor,

	/// <summary>
	/// fair
	/// </summary>
	[EnumMember(Value = "fair")]
	Fair,

	/// <summary>
	/// good
	/// </summary>
	[EnumMember(Value = "good")]
	Good
}