namespace Meraki.Api.Data;
/// <summary>
/// Sensor Alert Profile Condition Threshold IndoorAirQuality
/// </summary>
[DataContract]
public class SensorAlertConditionThresholdIndoorAirQuality
{
	/// <summary>
	/// IndoorAirQuality Score
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "score")]
	public int? Score { get; set; }

	/// <summary>
	/// IndoorAirQuality Quality
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "quality")]
	public SensorAlertConditionThresholdQuality? Quality { get; set; }
}