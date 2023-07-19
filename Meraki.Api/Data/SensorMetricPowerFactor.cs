namespace Meraki.Api.Data;

/// <summary>
/// Sensor metric: power factor
/// </summary>
[DataContract]
public class SensorMetricPowerFactor
{
	///<summary>
	/// Index
	/// </summary>
	[DataMember(Name = "index")]
	public int Index { get; set; }
}