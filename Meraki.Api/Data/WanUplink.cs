namespace Meraki.Api.Data;

/// <summary>
/// The physical WAN interface on which the traffic will arrive ('internet1' or, if available, 'internet2')
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum WanUplink
{
	/// <summary>
	/// Enum Internet1 for "internet1"
	/// </summary>
	[EnumMember(Value = "internet1")]
	Internet1 = 1,

	/// <summary>
	/// Enum Internet2 for "internet2"
	/// </summary>
	[EnumMember(Value = "internet2")]
	Internet2
}
