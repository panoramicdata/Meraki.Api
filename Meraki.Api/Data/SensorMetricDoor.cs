namespace Meraki.Api.Data;

/// <summary>
/// Sensor Metric for door
/// </summary>
[DataContract]
public class SensorMetricDoor
{
	///<summary>
	/// Door open
	/// </summary>
	[DataMember(Name = "open")]
	public bool Open { get; set; }
}