namespace Meraki.Api.Data;

/// <summary>
/// Per switch exception (combined, redundant, useNetworkSetting)
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PowerType
{
	/// <summary>
	/// Enum Combined for "combined"
	/// </summary>
	[EnumMember(Value = "combined")]
	Combined = 1,

	/// <summary>
	/// Enum Redundant for "redundant"
	/// </summary>
	[EnumMember(Value = "redundant")]
	Redundant,

	/// <summary>
	/// Enum UseNetworkSetting for "useNetworkSetting"
	/// </summary>
	[EnumMember(Value = "useNetworkSetting")]
	UseNetworkSetting
}
