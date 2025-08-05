namespace Meraki.Api.Data;

/// <summary>
/// Performance Class Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PerformanceClassType
{
	/// <summary>
	/// Builtin
	/// </summary>
	[EnumMember(Value = "builtin")]
	Builtin,

	/// <summary>
	/// Custom
	/// </summary>
	[EnumMember(Value = "custom")]
	Custom
}