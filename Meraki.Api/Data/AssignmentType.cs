namespace Meraki.Api.Data;

/// <summary>
/// Assignment Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum AssignmentType
{
	/// <summary>
	/// Allowed
	/// </summary>
	[EnumMember(Value = "allowed")]
	Allowed,

	/// <summary>
	/// Blocked
	/// </summary>
	[EnumMember(Value = "blocked")]
	Blocked,

	/// <summary>
	/// Group
	/// </summary>
	[EnumMember(Value = "group")]
	Group
}