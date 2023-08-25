namespace Meraki.Api.Data;

/// <summary>
/// Sensor metric: apparent power
/// </summary>
[DataContract]
public class SensorMetricApparentPower
{
	///<summary>
	/// Draw
	/// </summary>
	[DataMember(Name = "draw")]
	public double Draw { get; set; }
}
