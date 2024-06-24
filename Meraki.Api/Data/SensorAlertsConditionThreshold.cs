namespace Meraki.Api.Data;

/// <summary>
/// Sensor Alert Profile Condition Threshold
/// </summary>
[DataContract]
public class SensorAlertConditionThreshold
{
	/// <summary>
	/// Real power threshold. 'draw' must be provided.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "apparentPower")]
	public SensorAlertConditionThresholdApparentPower? ApparentPower { get; set; }

	/// <summary>
	/// CO2 concentration threshold. One of 'concentration' or 'quality' must be provided.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "co2")]
	public SensorAlertConditionThresholdCo2? Co2 { get; set; }

	/// <summary>
	/// Electrical current threshold. 'level' must be provided.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "current")]
	public SensorAlertConditionThresholdCurrent? Current { get; set; }

	/// <summary>
	/// Door Threshold
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "door")]
	public SensorAlertConditionThresholdDoor? Door { get; set; }

	/// <summary>
	/// Electrical frequency threshold. 'level' must be provided.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "frequency")]
	public SensorAlertConditionThresholdFrequency? Frequency { get; set; }

	/// <summary>
	/// Humidity Threshold
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "humidity")]
	public SensorAlertConditionThresholdHumidity? Humidity { get; set; }

	/// <summary>
	/// IndoorAirQuality Threshold
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "indoorAirQuality")]
	public SensorAlertConditionThresholdIndoorAirQuality? IndoorAirQuality { get; set; }

	/// <summary>
	/// Noise Threshold
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "noise")]
	public SensorAlertConditionThresholdNoise? Noise { get; set; }

	/// <summary>
	/// Pm25 Threshold
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "pm25")]
	public SensorAlertConditionThresholdPm25? Pm25 { get; set; }

	/// <summary>
	/// Power factor threshold. 'percentage' must be provided.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "powerFactor")]
	public SensorAlertConditionThresholdPowerFactor? PowerFactor { get; set; }

	/// <summary>
	/// Real power threshold. 'draw' must be provided.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "realPower")]
	public SensorAlertConditionThresholdRealPower? RealPower { get; set; }

	/// <summary>
	/// Temperature Threshold
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "temperature")]
	public SensorAlertConditionThresholdTemperature? Temperature { get; set; }

	/// <summary>
	/// Tvoc Threshold
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "tvoc")]
	public SensorAlertConditionThresholdTvoc? Tvoc { get; set; }

	/// <summary>
	/// Upstream power threshold. 'outageDetected' must be provided and set to true.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "upstreamPower")]
	public SensorAlertConditionThresholdUpstreamPower? upstreamPower { get; set; }

	/// <summary>
	/// Voltage threshold. 'level' must be provided.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "voltage")]
	public SensorAlertConditionThresholdVoltage? Voltage { get; set; }

	/// <summary>
	/// Water Threshold
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "water")]
	public SensorAlertConditionThresholdWater? Water { get; set; }
}