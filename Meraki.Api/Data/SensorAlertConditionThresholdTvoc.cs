namespace Meraki.Api.Data;
/// <summary>
/// Sensor Alert Profile Condition Threshold Tvoc
/// </summary>
[DataContract]
public class SensorAlertConditionThresholdTvoc
{
	/// <summary>
	/// Tvoc Threshold Concentration
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "concentration")]
	public int? Concentration { get; set; }

	/// <summary>
	/// Noise Threshold Quality
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "quality")]
	public SensorAlertConditionThresholdQuality? Quality { get; set; }
}