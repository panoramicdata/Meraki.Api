namespace Meraki.Api.Data;

public enum SensorCommandOperation
{
	[EnumMember(Value = "connect")]
	Connect = 1,

	[EnumMember(Value = "cycleDownstreamPower")]
	CycleDownstreamPower,

	[EnumMember(Value = "disableDownstreamPower")]
	DisableDownstreamPower,

	[EnumMember(Value = "enableDownstreamPower")]
	EnableDownstreamPower,
}