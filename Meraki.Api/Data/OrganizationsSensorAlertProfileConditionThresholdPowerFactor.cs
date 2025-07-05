namespace Meraki.Api.Data;

/// <summary>
/// Power factor threshold. 'percentage' must be provided
/// </summary>
[DataContract]
public class OrganizationsSensorAlertProfileConditionThresholdPowerFactor
{
	/// <summary>
	/// Alerting threshold as the ratio of active power to apparent power. Must be between 0 and 100. 
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "percentage")]
	public int Percentage { get; set; }
}