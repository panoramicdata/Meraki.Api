namespace Meraki.Api.Data;

/// <summary>
/// Sensor metric: power factor
/// </summary>
[DataContract]
public class SensorMetricPowerFactor
{
	///<summary>
	/// Percentage
	/// </summary>
	[DataMember(Name = "percentage")]
	public int Percentage { get; set; }
}
