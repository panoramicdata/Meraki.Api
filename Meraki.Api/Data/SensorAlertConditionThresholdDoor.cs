namespace Meraki.Api.Data;
/// <summary>
/// Sensor Alert Profile Condition Threshold Door
/// </summary>
[DataContract]
public class SensorAlertConditionThresholdDoor
{
	/// <summary>
	/// Door Open
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "open")]
	public bool? Open { get; set; }
}