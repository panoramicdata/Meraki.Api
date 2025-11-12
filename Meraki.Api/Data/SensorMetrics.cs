namespace Meraki.Api.Data;

/// <summary>
/// Types of sensor readings to retrieve. If no metrics are supplied, all available types of readings will be retrieved.
/// Allowed values are temperature, humidity, water, door, tvoc, pm25, noise, indoorAirQuality, button, and battery.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SensorMetrics
{
	[EnumMember(Value = "temperature")]
	/// <summary>
	/// Temperature
	/// </summary>
	Temperature,

	[EnumMember(Value = "humidity")]
	/// <summary>
	/// Humidity
	/// </summary>
	Humidity,

	[EnumMember(Value = "water")]
	/// <summary>
	/// Water
	/// </summary>
	Water,

	[EnumMember(Value = "door")]
	/// <summary>
	/// Door
	/// </summary>
	Door,

	[EnumMember(Value = "tvoc")]
	/// <summary>
	/// Tvoc
	/// </summary>
	Tvoc,

	[EnumMember(Value = "pm25")]
	/// <summary>
	/// Pm25
	/// </summary>
	Pm25,

	[EnumMember(Value = "noise")]
	/// <summary>
	/// Noise
	/// </summary>
	Noise,

	[EnumMember(Value = "indoorAirQuality")]
	/// <summary>
	/// Indoor Air Quality
	/// </summary>
	IndoorAirQuality,

	[EnumMember(Value = "button")]
	/// <summary>
	/// Button
	/// </summary>
	Button,

	[EnumMember(Value = "battery")]
	/// <summary>
	/// Battery
	/// </summary>
	Battery,

	[EnumMember(Value = "downstreamPower")]
	/// <summary>
	/// Downstream Power
	/// </summary>
	DownstreamPower,

	[EnumMember(Value = "current")]
	/// <summary>
	/// Current
	/// </summary>
	Current,

	[EnumMember(Value = "frequency")]
	/// <summary>
	/// Frequency
	/// </summary>
	Frequency,

	[EnumMember(Value = "voltage")]
	/// <summary>
	/// Voltage
	/// </summary>
	Voltage,

	[EnumMember(Value = "eco2")]
	/// <summary>
	/// Eco2
	/// </summary>
	Eco2,

	[EnumMember(Value = "powerFactor")]
	/// <summary>
	/// Power Factor
	/// </summary>
	PowerFactor,

	[EnumMember(Value = "apparentPower")]
	/// <summary>
	/// Apparent Power
	/// </summary>
	ApparentPower,

	[EnumMember(Value = "realPower")]
	/// <summary>
	/// Real Power
	/// </summary>
	RealPower,

	[EnumMember(Value = "remoteLockoutSwitch")]
	/// <summary>
	/// Remote Lockout Switch
	/// </summary>
	RemoteLockoutSwitch,

	[EnumMember(Value = "co2")]
	/// <summary>
	/// Co2
	/// </summary>
	Co2,

	[EnumMember(Value = "rawTemperature")]
	/// <summary>
	/// Raw Temperature
	/// </summary>
	RawTemperature,
}
