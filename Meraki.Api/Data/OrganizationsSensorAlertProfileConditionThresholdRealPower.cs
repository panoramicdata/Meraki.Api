namespace Meraki.Api.Data;

/// <summary>
/// Real power threshold. 'draw' must be provided.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertProfileConditionThresholdRealPower
{
	/// <summary>
	/// Alerting threshold in watts. Must be between 0 and 3750.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "draw")]
	public int Draw { get; set; }
}