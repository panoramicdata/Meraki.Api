namespace Meraki.Api.Data;
/// <summary>
/// Electrical current threshold. 'level' must be provided.
/// </summary>
[DataContract]
public class SensorAlertConditionThresholdCurrent
{
	/// <summary>
	/// Alerting threshold in amps. Must be between 0 and 15.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "draw")]
	public double Draw { get; set; }
}