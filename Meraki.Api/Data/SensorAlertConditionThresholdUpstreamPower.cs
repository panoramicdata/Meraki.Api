namespace Meraki.Api.Data;
/// <summary>
/// Sensor Alert Profile Condition Threshold Water
/// </summary>
[DataContract]
public class SensorAlertConditionThresholdUpstreamPower
{
	/// <summary>
	/// Alerting threshold for an upstream power event. Must be set to true.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "outageDetected")]
	public bool OutageDetected { get; set; } = true;
}