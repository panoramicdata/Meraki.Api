namespace Meraki.Api.Data;

public enum NetworksSwitchPortsProfilePortStpGuard
{
	/// <summary>
	/// BpduGuard
	/// </summary>
	[EnumMember(Value = "bpdu guard")]
	BpduGuard,

	/// <summary>
	/// Disabled
	/// </summary>
	[EnumMember(Value = "disabled")]
	Disabled,

	/// <summary>
	/// LoopGuard
	/// </summary>
	[EnumMember(Value = "loop guard")]
	LoopGuard,

	/// <summary>
	/// RootGuard
	/// </summary>
	[EnumMember(Value = "root guard")]
	RootGuard,
}