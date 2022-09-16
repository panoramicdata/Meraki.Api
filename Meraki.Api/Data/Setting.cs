namespace Meraki.Api.Data;

/// <summary>
/// How bandwidth limits are enforced. Can be 'network default', 'ignore' or 'custom'.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum Setting
{
	/// <summary>
	/// Network default
	/// </summary>
	[EnumMember(Value = "network default")]
	Networkdefault,

	/// <summary>
	/// Ignore
	/// </summary>
	[EnumMember(Value = "ignore")]
	Ignore,

	/// <summary>
	/// Custom
	/// </summary>
	[EnumMember(Value = "custom")]
	Custom
}
