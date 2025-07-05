namespace Meraki.Api.Data;

/// <summary>
/// Reading information over the interval for the 'temperature' metric. This will only be present if the 'metric' property equals 'temperature'.
/// </summary>
[DataContract]
public class OrganizationSensorReadingsHistoryByIntervalItemTemperature
{
	/// <summary>
	/// Aggregated temperature readings in degrees Celsius.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "celsius")]
	public OrganizationSensorReadingsHistoryByIntervalItemTemperatureCelsius Celsius { get; set; } = new();

	/// <summary>
	/// Aggregated temperature readings in degrees Fahrenheit.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "fahrenheit")]
	public OrganizationSensorReadingsHistoryByIntervalItemTemperatureFahrenheit Fahrenheit { get; set; } = new();
}
