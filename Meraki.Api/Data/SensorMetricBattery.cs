namespace Meraki.Api.Data;

/// <summary>
/// Sensor Metric battery
/// </summary>
[DataContract]
public class SensorMetricBattery
{
	///<summary>
	/// Battery percentage
	/// </summary>
	[DataMember(Name = "percentage")]
	public int Percentage { get; set; }
}