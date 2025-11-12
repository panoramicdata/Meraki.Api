namespace Meraki.Api.Data;

/// <summary>
/// Sensor Command Operation
/// </summary>
public enum SensorCommandOperation
{
	[EnumMember(Value = "connect")]
	/// <summary>
	/// Connect
	/// </summary>
	Connect = 1,

	[EnumMember(Value = "cycleDownstreamPower")]
	/// <summary>
	/// Cycle Downstream Power
	/// </summary>
	CycleDownstreamPower,

	[EnumMember(Value = "disableDownstreamPower")]
	/// <summary>
	/// Disable Downstream Power
	/// </summary>
	DisableDownstreamPower,

	[EnumMember(Value = "enableDownstreamPower")]
	/// <summary>
	/// Enable Downstream Power
	/// </summary>
	EnableDownstreamPower,

	[EnumMember(Value = "refreshData")]
	/// <summary>
	/// Refresh Data
	/// </summary>
	RefreshData,
}
