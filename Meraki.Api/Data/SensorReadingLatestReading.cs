namespace Meraki.Api.Data;

/// <summary>
/// Sensor Readings
/// See: https://documentation.meraki.com/MT/MT_General_Articles/MT14_Metrics_Explained
/// </summary>
[DataContract]
public class SensorReadingLatestReading
{
	/// <summary>
	/// Gets the ts
	/// </summary>
	[DataMember(Name = "ts")]
	public string Ts { get; set; } = string.Empty;

	/// <summary>
	/// Gets the sensor metric
	/// </summary>
	[DataMember(Name = "metric")]
	public SensorMetrics SensorMetric { get; set; }

	/// <summary>
	/// Gets the apparent power
	/// </summary>
	[DataMember(Name = "apparentPower")]
	public SensorMetricApparentPower? ApparentPower { get; set; }

	/// <summary>
	/// Gets the battery
	/// </summary>
	[DataMember(Name = "battery")]
	public SensorMetricBattery? Battery { get; set; }

	/// <summary>
	/// Gets the button
	/// </summary>
	[DataMember(Name = "button")]
	public SensorMetricButton? Button { get; set; }

	/// <summary>
	/// Gets the current
	/// </summary>
	[DataMember(Name = "current")]
	public SensorMetricCurrent? Current { get; set; }

	/// <summary>
	/// Gets the co2
	/// </summary>
	[DataMember(Name = "co2")]
	public SensorMetricCo2? Co2 { get; set; }

	/// <summary>
	/// Gets the door
	/// </summary>
	[DataMember(Name = "door")]
	public SensorMetricDoor? Door { get; set; }

	/// <summary>
	/// Gets the downstream power
	/// </summary>
	[DataMember(Name = "downstreamPower")]
	public SensorMetricDownstreamPower? DownstreamPower { get; set; }

	/// <summary>
	/// Gets the eco2
	/// </summary>
	[DataMember(Name = "eco2")]
	public SensorMetricConcentration? Eco2 { get; set; }

	/// <summary>
	/// Gets the frequency
	/// </summary>
	[DataMember(Name = "frequency")]
	public SensorMetricLevel? Frequency { get; set; }

	/// <summary>
	/// Gets the humidity
	/// </summary>
	[DataMember(Name = "humidity")]
	public SensorMetricHumidity? Humidity { get; set; }

	/// <summary>
	/// Gets the indoor air quality
	/// </summary>
	[DataMember(Name = "indoorAirQuality")]
	public SensorMetricIndoorAirQuality? IndoorAirQuality { get; set; }

	/// <summary>
	/// Gets the noise
	/// </summary>
	[DataMember(Name = "noise")]
	public SensorMetricNoise? Noise { get; set; }

	/// <summary>
	/// Gets the pm25
	/// </summary>
	[DataMember(Name = "pm25")]
	public SensorMetricConcentration? Pm25 { get; set; }

	/// <summary>
	/// Gets the power factor
	/// </summary>
	[DataMember(Name = "powerFactor")]
	public SensorMetricPowerFactor? PowerFactor { get; set; }

	/// <summary>
	/// Gets the raw temperature
	/// </summary>
	[DataMember(Name = "rawTemperature")]
	public SensorMetricRawTemperature? RawTemperature { get; set; }

	/// <summary>
	/// Gets the real power
	/// </summary>
	[DataMember(Name = "realPower")]
	public SensorMetricRealPower? RealPower { get; set; }

	/// <summary>
	/// Gets the remote lockout switch
	/// </summary>
	[DataMember(Name = "remoteLockoutSwitch")]
	public SensorMetricRemoteLockoutSwitch? RemoteLockoutSwitch { get; set; }

	/// <summary>
	/// Gets the temperature
	/// </summary>
	[DataMember(Name = "temperature")]
	public SensorMetricTemperature? Temperature { get; set; }

	/// <summary>
	/// Gets the tvoc
	/// </summary>
	[DataMember(Name = "tvoc")]
	public SensorMetricConcentration? Tvoc { get; set; }

	/// <summary>
	/// Gets the voltage
	/// </summary>
	[DataMember(Name = "voltage")]
	public SensorMetricLevel? Voltage { get; set; }

	/// <summary>
	/// Gets the water
	/// </summary>
	[DataMember(Name = "water")]
	public SensorMetricWater? Water { get; set; }
}
