namespace Meraki.Api.Data;

/// <summary>
/// Information about the supply voltage level of the port, in volts
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchItemPortReadingByMetricSupplyVoltageLevel
{
	/// <summary>
	/// The maximum supply voltage for the port over the interval, in volts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "maximum")]
	public int Maximum { get; set; }

	/// <summary>
	/// The median supply voltage for the port over the interval, in volts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "median")]
	public int Median { get; set; }

	/// <summary>
	/// The minimum supply voltage for the port over the interval, in volts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "minimum")]
	public int Minimum { get; set; }
}