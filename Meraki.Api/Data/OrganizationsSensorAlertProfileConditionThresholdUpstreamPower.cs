namespace Meraki.Api.Data;

/// <summary>
/// Upstream power threshold. 'outageDetected' must be provided and set to true.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertProfileConditionThresholdUpstreamPower
{
	/// <summary>
	/// Alerting threshold for an upstream power event. Must be set to true.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "outageDetected")]
	public bool OutageDetected { get; set; }
}