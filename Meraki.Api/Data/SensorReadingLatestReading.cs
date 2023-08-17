namespace Meraki.Api.Data;

/// <summary>
/// Sensor Readings
/// See: https://documentation.meraki.com/MT/MT_General_Articles/MT14_Metrics_Explained
/// </summary>
[DataContract]
public class SensorReadingLatestReading
{
	[DataMember(Name = "ts")]
	public string Ts { get; set; } = string.Empty;

	[DataMember(Name = "metric")]
	public SensorMetrics SensorMetric { get; set; }

	[DataMember(Name = "temperature")]
	public SensorMetricTemperature? Temperature { get; set; }

	[DataMember(Name = "humidity")]
	public SensorMetricHumidity? Humidity { get; set; }

	[DataMember(Name = "water")]
	public SensorMetricWater? Water { get; set; }

	[DataMember(Name = "door")]
	public SensorMetricDoor? Door { get; set; }

	[DataMember(Name = "tvoc")]
	public SensorMetricConcentration? Tvoc { get; set; }

	[DataMember(Name = "pm25")]
	public SensorMetricConcentration? Pm25 { get; set; }

	[DataMember(Name = "noise")]
	public SensorMetricNoise? Noise { get; set; }

	[DataMember(Name = "indoorAirQuality")]
	public SensorMetricIndoorAirQuality? IndoorAirQuality { get; set; }

	[DataMember(Name = "button")]
	public SensorMetricButton? Button { get; set; }

	[DataMember(Name = "battery")]
	public SensorMetricBattery? Battery { get; set; }

	[DataMember(Name = "downstreamPower")]
	public SensorMetricDownstreamPower? DownstreamPower { get; set; }

	[DataMember(Name = "power")]
	public SensorMetricPower? Power { get; set; }

	[DataMember(Name = "current")]
	public SensorMetricCurrent? Current { get; set; }

	[DataMember(Name = "frequency")]
	public SensorMetricLevel? Frequency { get; set; }

	[DataMember(Name = "voltage")]
	public SensorMetricLevel? Voltage { get; set; }

	[DataMember(Name = "eco2")]
	public SensorMetricConcentration? Eco2 { get; set; }

	[DataMember(Name = "powerFactor")]
	public SensorMetricPowerFactor? PowerFactor { get; set; }

	[DataMember(Name = "apparentPower")]
	public SensorMetricApparentPower? ApparentPower { get; set; }

	[DataMember(Name = "realPower")]
	public SensorMetricRealPower? RealPower { get; set; }

	[DataMember(Name = "remoteLockoutSwitch")]
	public SensorMetricRemoteLockoutSwitch? RemoteLockoutSwitch { get; set; }
}