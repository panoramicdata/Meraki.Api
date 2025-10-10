namespace Meraki.Api.Data;

/// <summary>
/// Sensor metric: raw temperature
/// </summary>
[DataContract]
public class SensorMetricRawTemperature
{
	///<summary>
	/// Temperature reading in degrees Celsius unadjusted for any normally applied calibration offset.
	/// </summary>
	[DataMember(Name = "celsius")]
	public double Celsius { get; set; }

	///<summary>
	/// Temperature reading in degrees Fahrenheit unadjusted for any normally applied calibration offset.
	/// </summary>
	[DataMember(Name = "fahrenheit")]
	public double Fahrenheit { get; set; }
}
