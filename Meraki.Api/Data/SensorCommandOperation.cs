namespace Meraki.Api.Data;

/// <summary>
/// Sensor Command Operation
/// </summary>
public enum SensorCommandOperation
{
	/// <summary>
	/// Connect
	/// </summary>
	[EnumMember(Value = "connect")]
	Connect = 1,

	/// <summary>
	/// Cycle Downstream Power
	/// </summary>
	[EnumMember(Value = "cycleDownstreamPower")]
	CycleDownstreamPower,

	/// <summary>
	/// Disable Downstream Power
	/// </summary>
	[EnumMember(Value = "disableDownstreamPower")]
	DisableDownstreamPower,

	/// <summary>
	/// Enable Downstream Power
	/// </summary>
	[EnumMember(Value = "enableDownstreamPower")]
	EnableDownstreamPower,

	/// <summary>
	/// Refresh Data
	/// </summary>
	[EnumMember(Value = "refreshData")]
	RefreshData,
}
