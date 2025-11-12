namespace Meraki.Api.Data;

/// <summary>
/// Types of sensor readings to retrieve. If no metrics are supplied, all available types of readings will be retrieved.
/// Allowed values are temperature, humidity, water, door, tvoc, pm25, noise, indoorAirQuality, button, and battery.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SensorMetrics
{
	/// <summary>
	/// Temperature
	/// </summary>
	[EnumMember(Value = "temperature")]
	Temperature,


	/// <summary>
	/// Humidity
	/// </summary>
	[EnumMember(Value = "humidity")]
	Humidity,


	/// <summary>
	/// Water
	/// </summary>
	[EnumMember(Value = "water")]
	Water,


	/// <summary>
	/// Door
	/// </summary>
	[EnumMember(Value = "door")]
	Door,


	/// <summary>
	/// Tvoc
	/// </summary>
	[EnumMember(Value = "tvoc")]
	Tvoc,


	/// <summary>
	/// Pm25
	/// </summary>
	[EnumMember(Value = "pm25")]
	Pm25,


	/// <summary>
	/// Noise
	/// </summary>
	[EnumMember(Value = "noise")]
	Noise,


	/// <summary>
	/// Indoor Air Quality
	/// </summary>
	[EnumMember(Value = "indoorAirQuality")]
	IndoorAirQuality,


	/// <summary>
	/// Button
	/// </summary>
	[EnumMember(Value = "button")]
	Button,


	/// <summary>
	/// Battery
	/// </summary>
	[EnumMember(Value = "battery")]
	Battery,


	/// <summary>
	/// Downstream Power
	/// </summary>
	[EnumMember(Value = "downstreamPower")]
	DownstreamPower,


	/// <summary>
	/// Current
	/// </summary>
	[EnumMember(Value = "current")]
	Current,


	/// <summary>
	/// Frequency
	/// </summary>
	[EnumMember(Value = "frequency")]
	Frequency,


	/// <summary>
	/// Voltage
	/// </summary>
	[EnumMember(Value = "voltage")]
	Voltage,


	/// <summary>
	/// Eco2
	/// </summary>
	[EnumMember(Value = "eco2")]
	Eco2,


	/// <summary>
	/// Power Factor
	/// </summary>
	[EnumMember(Value = "powerFactor")]
	PowerFactor,


	/// <summary>
	/// Apparent Power
	/// </summary>
	[EnumMember(Value = "apparentPower")]
	ApparentPower,


	/// <summary>
	/// Real Power
	/// </summary>
	[EnumMember(Value = "realPower")]
	RealPower,


	/// <summary>
	/// Remote Lockout Switch
	/// </summary>
	[EnumMember(Value = "remoteLockoutSwitch")]
	RemoteLockoutSwitch,


	/// <summary>
	/// Co2
	/// </summary>
	[EnumMember(Value = "co2")]
	Co2,


	/// <summary>
	/// Raw Temperature
	/// </summary>
	[EnumMember(Value = "rawTemperature")]
	RawTemperature,
}
