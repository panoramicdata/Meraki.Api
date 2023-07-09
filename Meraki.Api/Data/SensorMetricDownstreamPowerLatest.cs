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

/// <summary>
/// Sensor metric: downstreamPower for history endpoint
/// </summary>
[DataContract]
public class SensorMetricDownstreamPowerHistoric
{
	///<summary>
	/// Locked
	/// </summary>
	[DataMember(Name = "locked")]
	public bool Locked { get; set; }

	///<summary>
	/// Enabled
	/// </summary>
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }
}

