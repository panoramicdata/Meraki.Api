namespace Meraki.Api.Data;

/// <summary>
/// Sensor Metric for co2
/// </summary>
[DataContract]
public class SensorMetricCo2
{
	///<summary>
	/// CO2 reading in parts per million.
	/// </summary>
	[DataMember(Name = "concentration")]
	public int Concentration { get; set; }
}