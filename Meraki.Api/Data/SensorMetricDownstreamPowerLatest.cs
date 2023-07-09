namespace Meraki.Api.Data;

/// <summary>
/// Sensor metric: downstreamPower for Latest endpoint
/// </summary>
[DataContract]
public class SensorMetricDownstreamPowerLatest
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
