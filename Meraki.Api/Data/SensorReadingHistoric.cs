namespace Meraki.Api.Data;
/// <summary>
/// Sensor Readings
/// </summary>
[DataContract]

public class SensorReadingHistoric
{
	[DataMember(Name = "ts")]
	public string Ts { get; set; } = string.Empty;

	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	[DataMember(Name = "network")]
	public SensorReadingNetwork SensorReadingNetwork { get; set; } = new();

	[DataMember(Name = "metric")]
	public SensorMetrics SensorMetric { get; set; }

	// Logically only one of the settings below will be returned, based on the SensorMetric value
	// When we have time we could implement a custom deserialization implementation using discrimination
	// returning a "SensorMetric" which would then be one of the below types
	// Also there is no documentation for the structure of each sensor's values so we can't get any
	// further. The documentation only shows the response for temperature.

	[DataMember(Name = "downstreamPower")]
	public SensorMetricDownstreamPowerHistoric? DownstreamPower { get; set; }

	[DataMember(Name = "current")]
	public SensorMetricCurrent? Current { get; set; }

	[DataMember(Name = "frequency")]
	public SensorMetricLevel? Frequency { get; set; }

	[DataMember(Name = "voltage")]
	public SensorMetricLevel? Voltage { get; set; }

	[DataMember(Name = "eco2")]
	public SensorMetricConcentration? Eco2 { get; set; }

	[DataMember(Name = "power")]
	public SensorMetricPower? Power { get; set; }

	[DataMember(Name = "realPower")]
	public SensorMetricRealPower? RealPower { get; set; }

	[DataMember(Name = "apparentPower")]
	public SensorMetricApparentPower? ApparentPower { get; set; }

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
}