namespace Meraki.Api.Data;

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
