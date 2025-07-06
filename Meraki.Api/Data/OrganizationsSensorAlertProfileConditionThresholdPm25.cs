namespace Meraki.Api.Data;

/// <summary>
/// PM2.5 concentration threshold. One of 'concentration' or 'quality' must be provided.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertProfileConditionThresholdPm25
{
	/// <summary>
	/// Alerting threshold as PM2.5 parts per million.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "concentration")]
	public int Concentration { get; set; }

	/// <summary>
	/// Alerting threshold as a qualitative PM2.5 level.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "quality")]
	public AlertingQuality Quality { get; set; }
}