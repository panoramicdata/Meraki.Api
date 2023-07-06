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
	[DataMember(Name = "real")]
	public SensorMetricPowerFactor Factor { get; set; } = new();
}

/// <summary>
/// Sensor metric: power
/// </summary>
[DataContract]
public class SensorMetricDownstreamPower
{
	///<summary>
	/// Override
	/// </summary>
	[DataMember(Name = "override")]
	public SensorMetricDownstreamPowerState Override { get; set; }

	///<summary>
	/// State
	/// </summary>
	[DataMember(Name = "state")]
	public SensorMetricDownstreamPowerState State { get; set; }
}
