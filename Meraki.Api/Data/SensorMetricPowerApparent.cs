namespace Meraki.Api.Data;

/// <summary>
/// Sensor metric: Apparent power
/// </summary>
[DataContract]
public class SensorMetricPowerApparent
{
	///<summary>
	/// Magnitude
	/// </summary>
	[DataMember(Name = "magnitude")]
	public double Magnitude { get; set; }
}
