namespace Meraki.Api.Data;

/// <summary>
/// Electrical current threshold. 'level' must be provided.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertProfileConditionThresholdCurrent
{
	/// <summary>
	/// Alerting threshold in amps. Must be between 0 and 15.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "draw")]
	public int Draw { get; set; }
}