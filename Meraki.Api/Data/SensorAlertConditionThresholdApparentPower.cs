namespace Meraki.Api.Data;
/// <summary>
/// Apparent power threshold. 'draw' must be provided.
/// </summary>
[DataContract]
public class SensorAlertConditionThresholdApparentPower
{
	/// <summary>
	/// Alerting threshold in volt-amps. Must be between 0 and 3750.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "draw")]
	public double Draw { get; set; }
}