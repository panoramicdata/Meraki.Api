namespace Meraki.Api.Data;

/// <summary>
/// Sensor metric: power
/// </summary>
[DataContract]
public class SensorMetricPower
{
	///<summary>
	/// Apparent Power
	/// </summary>
	[DataMember(Name = "apparent")]
	public SensorMetricPowerApparent Apparent { get; set; } = new();

	///<summary>
	/// Real Power
	/// </summary>
	[DataMember(Name = "real")]
	public SensorMetricPowerReal Real { get; set; } = new();

	///<summary>
	/// Factor
	/// </summary>
	[DataMember(Name = "factor")]
	public SensorMetricPowerFactor Factor { get; set; } = new();
}
