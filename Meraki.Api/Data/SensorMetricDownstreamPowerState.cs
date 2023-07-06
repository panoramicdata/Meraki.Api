namespace Meraki.Api.Data;

/// <summary>
/// Downstream power state
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SensorMetricDownstreamPowerState
{
	/// <summary>
	/// Enabled
	/// </summary>
	[EnumMember(Value = "enabled")]
	Enabled = 1,

	/// <summary>
	/// Disabled
	/// </summary>
	[EnumMember(Value = "disabled")]
	Disabled,
}