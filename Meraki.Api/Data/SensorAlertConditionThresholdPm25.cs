namespace Meraki.Api.Data;
/// <summary>
/// Sensor Alert Profile Condition Threshold Pm25
/// </summary>
[DataContract]
public class SensorAlertConditionThresholdPm25
{
	/// <summary>
	/// Pm25 Threshold Concentration
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "concentration")]
	public int? Concentration { get; set; }

	/// <summary>
	/// Pm25 Threshold Quality
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "quality")]
	public SensorAlertConditionThresholdQuality? Quality { get; set; }
}