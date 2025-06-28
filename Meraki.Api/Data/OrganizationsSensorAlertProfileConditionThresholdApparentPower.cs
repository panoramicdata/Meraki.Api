namespace Meraki.Api.Data;

/// <summary>
/// Apparent power threshold. 'draw' must be provided.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertProfileConditionThresholdApparentPower
{
	/// <summary>
	/// Alerting threshold in volt-amps. Must be between 0 and 3750.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "draw")]
	public int Draw { get; set; }
}