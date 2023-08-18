namespace Meraki.Api.Data;

/// <summary>
/// Sensor metric: real power
/// </summary>
[DataContract]
public class SensorMetricRealPower
{
	///<summary>
	/// Draw
	/// </summary>
	[DataMember(Name = "draw")]
	public double Draw { get; set; }
}
