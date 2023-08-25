namespace Meraki.Api.Data;

/// <summary>
/// Sensor metric: current
/// </summary>
[DataContract]
public class SensorMetricCurrent
{
	///<summary>
	/// Draw
	/// </summary>
	[DataMember(Name = "draw")]
	public double Draw { get; set; } = new();
}
