namespace Meraki.Api.Data;
/// <summary>
/// Sensor Readings
/// </summary>
[DataContract]

public class SensorReadingLatest
{
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	[DataMember(Name = "network")]
	public SensorReadingNetwork SensorReadingNetwork { get; set; } = new();

	[DataMember(Name = "readings")]
	public List<SensorReadingLatestReading> Readings { get; set; } = [];
}