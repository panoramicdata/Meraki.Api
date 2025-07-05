namespace Meraki.Api.Data;

/// <summary>
/// All reading data, grouped by the reading metric
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchItemPortReadingByMetric
{
	/// <summary>
	/// Information about the laser bias current of the port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "laserBiasCurrent")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchItemPortReadingByMetricLaserBiasCurrent LaserBiasCurrent { get; set; } = new();

	/// <summary>
	/// Information about the power transmitted and received by the port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "power")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchItemPortReadingByMetricPower Power { get; set; } = new();

	/// <summary>
	/// Information about the supply voltage of the port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "supplyVoltage")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchItemPortReadingByMetricSupplyVoltage SupplyVoltage { get; set; } = new();

	/// <summary>
	/// Information about the temperature of the port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "temperature")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchItemPortReadingByMetricTemperature Temperature { get; set; } = new();
}
