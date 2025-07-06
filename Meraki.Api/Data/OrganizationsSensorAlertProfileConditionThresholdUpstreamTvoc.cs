namespace Meraki.Api.Data;

/// <summary>
/// TVOC concentration threshold. One of 'concentration' or 'quality' must be provided.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertProfileConditionThresholdUpstreamTvoc
{
	/// <summary>
	/// Alerting threshold as TVOC micrograms per cubic meter.
	/// </summary> 
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "concentration")]
	public int Concentration { get; set; }

	/// <summary>
	/// Alerting threshold as a qualitative TVOC level.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "quality")]
	public AlertingQuality Quality { get; set; }
}