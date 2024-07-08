namespace Meraki.Api.Data;
/// <summary>
/// CO2 concentration threshold. One of 'concentration' or 'quality' must be provided.
/// </summary>
[DataContract]
public class SensorAlertConditionThresholdCo2
{
	/// <summary>
	/// Alerting threshold as CO2 parts per million.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "concentration")]
	public int? Concentration { get; set; }

	/// <summary>
	/// Alerting threshold as a qualitative CO2 level.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "quality")]
	public SensorAlertConditionThresholdCo2Quality? Quality { get; set; }
}