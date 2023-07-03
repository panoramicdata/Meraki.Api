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
	public SensorMetricTvoc? Tvoc { get; set; }

	[DataMember(Name = "pm25")]
	public SensorMetricPm25? Pm25 { get; set; }

	[DataMember(Name = "noise")]
	public SensorMetricNoise? Noise { get; set; }

	[DataMember(Name = "indoorAirQuality")]
	public SensorMetricIndoorAirQuality? IndoorAirQuality { get; set; }

	[DataMember(Name = "button")]
	public SensorMetricButton? Button { get; set; }

	[DataMember(Name = "battery")]
	public SensorMetricBattery? Battery { get; set; }
}