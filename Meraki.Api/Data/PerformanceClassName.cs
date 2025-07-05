namespace Meraki.Api.Data;

/// <summary>
/// Performance Class Name
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PerformanceClassName
{
	/// <summary>
	/// VoIP
	/// </summary>
	[EnumMember(Value = "VoIP")]
	VoIP
}