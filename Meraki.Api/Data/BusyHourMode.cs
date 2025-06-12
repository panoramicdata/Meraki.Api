namespace Meraki.Api.Data;

/// <summary>
/// Busy Hour Mode
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum BusyHourMode
{
	/// <summary>
	/// Automatic mode
	/// </summary>
	[EnumMember(Value = "automatic")]
	Automatic,

	/// <summary>
	/// Manual mode
	/// </summary>
	[EnumMember(Value = "manual")]
	Manual
}