namespace Meraki.Api.Data;
/// <summary>
/// Electrical frequency threshold. 'level' must be provided.
/// </summary>
[DataContract]
public class SensorAlertConditionThresholdFrequency
{
	/// <summary>
	/// Alerting threshold in hertz. Must be between 0 and 60.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "level")]
	public double Level { get; set; }
}