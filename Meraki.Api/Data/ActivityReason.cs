namespace Meraki.Api.Data;

/// <summary>
/// Activity Reason
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ActivityReason
{
	/// <summary>
	/// Dfs
	/// </summary>
	[EnumMember(Value = "dfs")]
	Dfs,

	/// <summary>
	/// Jammed
	/// </summary>
	[EnumMember(Value = "jammed")]
	Jammed
}