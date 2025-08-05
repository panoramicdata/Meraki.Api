namespace Meraki.Api.Data;

/// <summary>
/// Protocol Rule Type 
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ProtocolRuleType
{
	/// <summary>
	/// Any
	/// </summary>
	[EnumMember(Value = "any")]
	Any,

	/// <summary>
	/// Number
	/// </summary>
	[EnumMember(Value = "number")]
	Number,

	/// <summary>
	/// ObjectGroup
	/// </summary>
	[EnumMember(Value = "objectGroup")]
	ObjectGroup
}