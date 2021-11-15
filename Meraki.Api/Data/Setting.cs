namespace Meraki.Api.Data;

/// <summary>
/// How bandwidth limits are enforced. Can be 'network default', 'ignore' or 'custom'.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum Setting
{
	/// <summary>
	/// Enum Networkdefault for "network default"
	/// </summary>
	[EnumMember(Value = "network default")]
	Networkdefault,

	/// <summary>
	/// Enum Ignore for "ignore"
	/// </summary>
	[EnumMember(Value = "ignore")]
	Ignore,

	/// <summary>
	/// Enum Custom for "custom"
	/// </summary>
	[EnumMember(Value = "custom")]
	Custom
}
