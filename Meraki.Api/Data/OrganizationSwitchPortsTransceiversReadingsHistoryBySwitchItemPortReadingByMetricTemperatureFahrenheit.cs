namespace Meraki.Api.Data;

/// <summary>
/// Information about the temperature of the port in fahrenheit
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchItemPortReadingByMetricTemperatureFahrenheit
{
	/// <summary>
	/// The maximum temperature of the port over the interval, in fahrenheit
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "maximum")]
	public int Maximum { get; set; }

	/// <summary>
	/// The median temperature of the port over the interval, in fahrenheit
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "median")]
	public int Median { get; set; }

	/// <summary>
	/// The minimum temperature of the port over the interval, in fahrenheit
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "minimum")]
	public int Minimum { get; set; }
}