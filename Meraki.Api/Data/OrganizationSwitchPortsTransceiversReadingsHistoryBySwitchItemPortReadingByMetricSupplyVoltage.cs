namespace Meraki.Api.Data;

/// <summary>
/// 
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchItemPortReadingByMetricSupplyVoltage
{
	/// <summary>
	/// Information about the supply voltage level of the port, in volts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "level")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchItemPortReadingByMetricSupplyVoltageLevel Level { get; set; } = new();
}
