namespace Meraki.Api.Data;

/// <summary>
/// Door open threshold. 'open' must be provided and set to true.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertProfileConditionThresholdDoor
{
	/// <summary>
	/// Alerting threshold for a door open event. Must be set to true.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "open")]
	public bool Open { get; set; }
}