namespace Meraki.Api.Data;

/// <summary>
/// Ambient noise threshold. One of 'level' or 'quality' must be provided.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertProfileConditionThresholdNoiseAmbient
{
	/// <summary>
	/// Alerting threshold as adjusted decibels.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "level")]
	public int Level { get; set; }

	/// <summary>
	/// Alerting threshold as a qualitative ambient noise level.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "quality")]
	public AlertingQuality Quality { get; set; }
}