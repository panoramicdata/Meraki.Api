namespace Meraki.Api.Data;
/// <summary>
/// Sensor Alert Profile Condition Threshold Water
/// </summary>
[DataContract]
public class SensorAlertConditionThresholdWater
{
	/// <summary>
	/// Water Present
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "present")]
	public bool? Present { get; set; }
}