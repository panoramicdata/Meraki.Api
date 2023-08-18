namespace Meraki.Api.Data;

/// <summary>
/// Sensor metric: downstreamPower for Latest endpoint
/// </summary>
[DataContract]
public class SensorMetricDownstreamPower
{
	///<summary>
	/// State
	/// </summary>
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }
}
