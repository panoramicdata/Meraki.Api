namespace Meraki.Api.Data;
/// <summary>
/// Sensor Readings
/// </summary>
[DataContract]

public class SensorReadingLatestReading
{
	[DataMember(Name = "ts")]
	public string Ts { get; set; } = string.Empty;

	[DataMember(Name = "metric")]
	public SensorMetrics SensorMetric { get; set; }

	[DataMember(Name = "temperature")]
	public object? Temperature { get; set; }

	[DataMember(Name = "humidity")]
	public object? Humidity { get; set; }

	[DataMember(Name = "water")]
	public object? Water { get; set; }

	[DataMember(Name = "door")]
	public object? Door { get; set; }

	[DataMember(Name = "tvoc")]
	public object? Tvoc { get; set; }

	[DataMember(Name = "pm25")]
	public object? Pm25 { get; set; }

	[DataMember(Name = "noise")]
	public object? Noise { get; set; }

	[DataMember(Name = "indoorAirQuality")]
	public object? IndoorAirQuality { get; set; }

	[DataMember(Name = "button")]
	public object? Button { get; set; }

	[DataMember(Name = "battery")]
	public object? Battery { get; set; }
}