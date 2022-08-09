namespace Meraki.Api.Data;
/// <summary>
/// Sensor Alert Profile Condition Threshold Humidity
/// </summary>
[DataContract]
public class SensorAlertConditionThresholdHumidity
{
	/// <summary>
	/// Humidity Relative Percentage
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "relativePercentage")]
	public int? RelativePercentage { get; set; }

	/// <summary>
	/// Humidity Quality
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "quality")]
	public SensorAlertConditionThresholdQuality? Quality { get; set; }
}