namespace Meraki.Api.Data;

/// <summary>
/// Sensor Metric battery
/// </summary>
[DataContract]
public class SensorMetricLevel
{
	///<summary>
	/// Battery percentage
	/// </summary>
	[DataMember(Name = "level")]
	public double Level { get; set; }
}