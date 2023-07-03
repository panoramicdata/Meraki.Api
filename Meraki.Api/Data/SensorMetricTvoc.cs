namespace Meraki.Api.Data;

/// <summary>
/// Sensor Metric for TVOC
/// (total volatile organic compounds)
/// </summary>
[DataContract]
public class SensorMetricTvoc
{
	/// <summary>
	/// Total volatile organic compounds in parts per billion
	/// </summary>
	[DataMember(Name = "concentration")]
	public int ConcentrationPercent { get; set; }
}