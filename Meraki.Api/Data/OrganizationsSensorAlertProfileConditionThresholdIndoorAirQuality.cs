namespace Meraki.Api.Data;

/// <summary>
/// Indoor air quality score threshold. One of 'score' or 'quality' must be provided.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertProfileConditionThresholdIndoorAirQuality
{
	/// <summary>
	/// Alerting threshold as indoor air quality score.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "score")]
	public int Score { get; set; }

	/// <summary>
	/// Alerting threshold as a qualitative indoor air quality level.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "quality")]
	public AlertingQuality Quality { get; set; }
}