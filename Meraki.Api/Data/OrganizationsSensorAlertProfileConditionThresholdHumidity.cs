namespace Meraki.Api.Data;

/// <summary>
/// Humidity threshold. One of 'relativePercentage' or 'quality' must be provided.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertProfileConditionThresholdHumidity
{
	/// <summary>
	/// Alerting threshold in %RH.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "relativePercentage")]
	public int RelativePercentage { get; set; }

	/// <summary>
	/// Alerting threshold as a qualitative humidity level.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "quality")]
	public AlertingQuality Quality { get; set; }
}