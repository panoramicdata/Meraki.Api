namespace Meraki.Api.Data;

/// <summary>
/// Sensor Metric for temperature
/// </summary>
[DataContract]
public class SensorMetricTemperature
{
	///<summary>
	/// Temperature in degrees Celsius
	/// </summary>
	[DataMember(Name = "celsius")]
	public double? Celsius { get; set; }

	///<summary>
	/// Temperature in degrees Fahrenheit
	/// </summary>
	[DataMember(Name = "fahrenheit")]
	public double? Fahrenheit { get; set; }
}