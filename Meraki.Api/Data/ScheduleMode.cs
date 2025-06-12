namespace Meraki.Api.Data;

/// <summary>
/// Schedule mode
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ScheduleMode
{
	/// <summary>
	/// Enabled
	/// </summary>
	[EnumMember(Value = "enabled")]
	Enabled,

	/// <summary>
	/// Disabled
	/// </summary>
	[EnumMember(Value = "disabled")]
	Disabled
}