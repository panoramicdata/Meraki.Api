namespace Meraki.Api.Data;
/// <summary>
/// Sensor Alert Profile Condition Threshold Noise
/// </summary>
[DataContract]
public class SensorAlertConditionThresholdNoise
{
	/// <summary>
	/// Noise Ambient
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "ambient")]
	public SensorAlertConditionThresholdNoiseAmbient? Ambient { get; set; }
}