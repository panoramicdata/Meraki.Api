namespace Meraki.Api.Data;
/// <summary>
/// Voltage threshold. 'level' must be provided.
/// </summary>
[DataContract]
public class SensorAlertConditionThresholdVoltage
{
	/// <summary>
	/// Alerting threshold in volts. Must be between 0 and 250.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "level")]
	public double Level { get; set; }
}