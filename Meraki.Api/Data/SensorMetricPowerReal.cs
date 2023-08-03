namespace Meraki.Api.Data;

/// <summary>
/// Sensor metric: power factor
/// </summary>
[DataContract]
public class SensorMetricPowerReal
{
	///<summary>
	/// Draw
	/// </summary>
	[DataMember(Name = "draw")]
	public double Draw { get; set; }
}
