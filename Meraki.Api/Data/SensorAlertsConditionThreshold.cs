namespace Meraki.Api.Data;

/// <summary>
/// Sensor Alert Profile Condition Threshold
/// </summary>
[DataContract]
public class SensorAlertConditionThreshold
{
	/// <summary>
	/// Door Threshold
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "door")]
	public SensorAlertConditionThresholdDoor? Door { get; set; }

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
	/// Water Threshold
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "water")]
	public SensorAlertConditionThresholdWater? Water { get; set; }
}