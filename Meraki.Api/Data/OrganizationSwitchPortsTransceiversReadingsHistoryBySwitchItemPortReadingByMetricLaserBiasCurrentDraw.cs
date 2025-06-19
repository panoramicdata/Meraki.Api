namespace Meraki.Api.Data;

/// <summary>
/// Information about the laser bias current draw of the port, in mA
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchItemPortReadingByMetricLaserBiasCurrentDraw
{
	/// <summary>
	/// The maximum laser bias current for the port over the interval, in mA
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "maximum")]
	public int Maximum { get; set; }

	/// <summary>
	/// The median laser bias current for the port over the interval, in mA
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "median")]
	public int Median { get; set; }

	/// <summary>
	/// The minimum laser bias current for the port over the interval, in mA
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "minimum")]
	public int Minimum { get; set; }
}