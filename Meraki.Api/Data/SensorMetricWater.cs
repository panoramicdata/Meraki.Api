namespace Meraki.Api.Data;

/// <summary>
/// Sensor Metric for water
/// </summary>
[DataContract]
public class SensorMetricWater
{
	///<summary>
	/// Water detected
	/// </summary>
	[DataMember(Name = "present")]
	public bool Present { get; set; }
}