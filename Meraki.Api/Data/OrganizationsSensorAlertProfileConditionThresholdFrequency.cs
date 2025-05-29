namespace Meraki.Api.Data;

/// <summary>
/// Electrical frequency threshold. 'level' must be provided.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertProfileConditionThresholdFrequency
{
	/// <summary>
	/// Alerting threshold in hertz. Must be between 0 and 60.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "level")]
	public int Level { get; set; }
}