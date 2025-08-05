namespace Meraki.Api.Data;

/// <summary>
/// Information about the power transmitted by the port
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchItemPortReadingByMetricPowerTransmit
{
	/// <summary>
	/// The maximum value for power transmitted by the port over the interval, in dBm
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "maximum")]
	public int Maximum { get; set; }

	/// <summary>
	/// The median value for power transmitted by the port over the interval, in dBm
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "median")]
	public int Median { get; set; }

	/// <summary>
	/// The minimum value for power transmitted by the port over the interval, in dBm
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "minimum")]
	public int Minimum { get; set; }
}