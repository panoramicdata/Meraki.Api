namespace Meraki.Api.Data;

/// <summary>
/// Sensor Metric for indoor air quality
/// </summary>
[DataContract]
public class SensorMetricIndoorAirQuality
{
	///<summary>
	/// Score
	/// </summary>
	[DataMember(Name = "score")]
	public int Score { get; set; }
}