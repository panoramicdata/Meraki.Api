namespace Meraki.Api.Data;
/// <summary>
/// Real power threshold. 'draw' must be provided.
/// </summary>
[DataContract]
public class SensorAlertConditionThresholdRealPower
{
	/// <summary>
	/// Alerting threshold in watts. Must be between 0 and 3750.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "draw")]
	public double Draw { get; set; }
}