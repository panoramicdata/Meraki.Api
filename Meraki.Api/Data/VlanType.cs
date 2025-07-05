namespace Meraki.Api.Data;

/// <summary>
/// Vlan Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum VlanType
{
	/// <summary>
	/// Same
	/// </summary>
	[EnumMember(Value = "same")]
	Same,

	/// <summary>
	/// Unique
	/// </summary>
	[EnumMember(Value = "unique")]
	Unique,
}