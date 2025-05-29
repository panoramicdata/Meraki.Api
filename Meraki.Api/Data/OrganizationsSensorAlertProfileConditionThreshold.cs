namespace Meraki.Api.Data;

/// <summary>
/// Threshold for sensor readings that will cause an alert to be sent. This object should contain a single property key matching the condition's 'metric' value.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertProfileConditionThreshold
{
	/// <summary>
	/// Apparent power threshold. 'draw' must be provided.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "apparentPower")]
	public OrganizationsSensorAlertProfileConditionThresholdApparentPower ApparentPower { get; set; } = new();

	/// <summary>
	/// CO2 concentration threshold. One of 'concentration' or 'quality' must be provided.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "co2")]
	public OrganizationsSensorAlertProfileConditionThresholdCo2 Co2 { get; set; } = new();

	/// <summary>
	/// Electrical current threshold. 'level' must be provided.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "current")]
	public OrganizationsSensorAlertProfileConditionThresholdCurrent Current { get; set; } = new();

	/// <summary>
	/// Door open threshold. 'open' must be provided and set to true.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "door")]
	public OrganizationsSensorAlertProfileConditionThresholdDoor Door { get; set; } = new();

	/// <summary>
	/// Electrical frequency threshold. 'level' must be provided.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "frequency")]
	public OrganizationsSensorAlertProfileConditionThresholdFrequency Frequency { get; set; } = new();

	/// <summary>
	/// Humidity threshold. One of 'relativePercentage' or 'quality' must be provided.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "humidity")]
	public OrganizationsSensorAlertProfileConditionThresholdHumidity Humidity { get; set; } = new();

	/// <summary>
	/// Indoor air quality score threshold. One of 'score' or 'quality' must be provided.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "indoorAirQuality")]
	public OrganizationsSensorAlertProfileConditionThresholdIndoorAirQuality IndoorAirQuality { get; set; } = new();

	/// <summary>
	/// Noise threshold. 'ambient' must be provided
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "noise")]
	public OrganizationsSensorAlertProfileConditionThresholdNoise Noise { get; set; } = new();

	/// <summary>
	/// PM2.5 concentration threshold. One of 'concentration' or 'quality' must be provided.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "pm25")]
	public OrganizationsSensorAlertProfileConditionThresholdPm25 Pm25 { get; set; } = new();

	/// <summary>
	/// Power factor threshold. 'percentage' must be provided
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "powerFactor")]
	public OrganizationsSensorAlertProfileConditionThresholdPowerFactor PowerFactor { get; set; } = new();

	/// <summary>
	/// Real power threshold. 'draw' must be provided.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "realPower")]
	public OrganizationsSensorAlertProfileConditionThresholdRealPower RealPower { get; set; } = new();

	/// <summary>
	/// Temperature threshold. One of 'celsius', 'fahrenheit', or 'quality' must be provided.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "temperature")]
	public OrganizationsSensorAlertProfileConditionThresholdTemperature Temperature { get; set; } = new();

	/// <summary>
	/// TVOC concentration threshold. One of 'concentration' or 'quality' must be provided.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tvoc")]
	public OrganizationsSensorAlertProfileConditionThresholdUpstreamTvoc Tvoc { get; set; } = new();

	/// <summary>
	/// Upstream power threshold. 'outageDetected' must be provided and set to true.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "upstreamPower")]
	public OrganizationsSensorAlertProfileConditionThresholdUpstreamPower UpstreamPower { get; set; } = new();

	/// <summary>
	/// Voltage threshold. 'level' must be provided.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "voltage")]
	public OrganizationsSensorAlertProfileConditionThresholdVoltage Voltage { get; set; } = new();

	/// <summary>
	/// Water detection threshold. 'present' must be provided and set to true.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "water")]
	public OrganizationsSensorAlertProfileConditionThresholdWater Water { get; set; } = new();
}
