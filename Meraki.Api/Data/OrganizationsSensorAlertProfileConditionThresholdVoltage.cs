namespace Meraki.Api.Data;

/// <summary>
/// Voltage threshold. 'level' must be provided.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertProfileConditionThresholdVoltage
{
	/// <summary>
	/// Alerting threshold in volts. Must be between 0 and 250.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "level")]
	public int Level { get; set; }
}