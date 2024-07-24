namespace Meraki.Api.Data;

/// <summary>
/// Metrics available for sensor alert condition profiles
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SensorAlertConditionMetric
{
	/// <summary>
	/// temperature
	/// </summary>
	[EnumMember(Value = "temperature")]
	Temperature,

	/// <summary>
	/// humidity
	/// </summary>
	[EnumMember(Value = "humidity")]
	Humidity,

	/// <summary>
	/// water
	/// </summary>
	[EnumMember(Value = "water")]
	Water,

	/// <summary>
	/// door
	/// </summary>
	[EnumMember(Value = "door")]
	Door,

	/// <summary>
	/// tvoc
	/// </summary>
	[EnumMember(Value = "tvoc")]
	Tvoc,

	/// <summary>
	/// pm25
	/// </summary>
	[EnumMember(Value = "pm25")]
	Pm25,

	/// <summary>
	/// noise
	/// </summary>
	[EnumMember(Value = "noise")]
	Noise,

	/// <summary>
	/// Co2
	/// </summary>
	[EnumMember(Value = "co2")]
	Co2,

	/// <summary>
	/// indoorAirQuality
	/// </summary>
	[EnumMember(Value = "indoorAirQuality")]
	IndoorAirQuality
}