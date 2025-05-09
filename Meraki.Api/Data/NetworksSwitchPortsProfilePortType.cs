namespace Meraki.Api.Data;

[JsonConverter(typeof(StringEnumConverter))]
public enum NetworksSwitchPortsProfilePortType
{
	/// <summary>
	/// Access
	/// </summary>
	[EnumMember(Value = "access")]
	Access,

	/// <summary>
	/// Routed
	/// </summary>
	[EnumMember(Value = "routed")]
	Routed,

	/// <summary>
	/// Stack
	/// </summary>
	[EnumMember(Value = "stack")]
	Stack,

	/// <summary>
	/// Trunk
	/// </summary>
	[EnumMember(Value = "trunk")]
	Trunk
}