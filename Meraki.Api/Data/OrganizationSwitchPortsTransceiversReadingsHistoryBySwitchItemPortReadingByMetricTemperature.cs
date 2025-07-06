namespace Meraki.Api.Data;

/// <summary>
/// Information about the temperature of the port
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchItemPortReadingByMetricTemperature
{
	/// <summary>
	/// Information about the temperature of the port in celsius
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "celsius")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchItemPortReadingByMetricTemperatureCelsius Celsius { get; set; } = new();

	/// <summary>
	/// Information about the temperature of the port in fahrenheit
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "fahrenheit")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchItemPortReadingByMetricTemperatureFahrenheit Fahrenheit { get; set; } = new();
}
