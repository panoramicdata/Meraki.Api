namespace Meraki.Api.Data;
/// <summary>
/// Sensor Alert Profile Condition Threshold Ambient
/// </summary>
[DataContract]
public class SensorAlertConditionThresholdNoiseAmbient
{
	/// <summary>
	/// Noise Ambient Level
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "level")]
	public int? Level { get; set; }

	/// <summary>
	/// Noise Ambient Quality
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "quality")]
	public SensorAlertConditionThresholdQuality? Quality { get; set; }
}