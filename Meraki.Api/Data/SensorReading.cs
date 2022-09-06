namespace Meraki.Api.Data;
/// <summary>
/// Sensor Readings
/// </summary>
[DataContract]

public class SensorReading
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