namespace Meraki.Api.Data;

/// <summary>
/// Types of sensor readings to retrieve. If no metrics are supplied, all available types of readings will be retrieved.
/// Allowed values are temperature, humidity, water, door, tvoc, pm25, noise, indoorAirQuality, button, and battery.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SensorMetrics
{
	[EnumMember(Value = "temperature")]
	Temperature,

	[EnumMember(Value = "humidity")]
	Humidity,

	[EnumMember(Value = "water")]
	Water,

	[EnumMember(Value = "door")]
	Door,

	[EnumMember(Value = "tvoc")]
	Tvoc,

	[EnumMember(Value = "pm25")]
	Pm25,

	[EnumMember(Value = "noise")]
	Noise,

	[EnumMember(Value = "indoorAirQuality")]
	IndoorAirQuality,

	[EnumMember(Value = "button")]
	Button,

	[EnumMember(Value = "battery")]
	Battery,

	[EnumMember(Value = "downstreamPower")]
	DownstreamPower,

	[EnumMember(Value = "power")]
	Power,

	[EnumMember(Value = "current")]
	Current,
}