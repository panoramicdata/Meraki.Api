namespace Meraki.Api.Data;

/// <summary>
/// Sensor Metric for humidity
/// </summary>
[DataContract]
public class SensorMetricHumidity
{
	///<summary>
	/// Humidity in relative percentage
	/// </summary>
	[DataMember(Name = "relativePercentage")]
	public int RelativePercentage { get; set; }
}