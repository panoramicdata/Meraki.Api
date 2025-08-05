namespace Meraki.Api.Data;

/// <summary>
/// Water detection threshold. 'present' must be provided and set to true.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertProfileConditionThresholdWater
{
	/// <summary>
	/// Alerting threshold for a water detection event. Must be set to true.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "present")]
	public bool Present { get; set; }
}