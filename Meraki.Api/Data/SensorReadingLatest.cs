namespace Meraki.Api.Data;
/// <summary>
/// Sensor Readings
/// </summary>
[DataContract]

public class SensorReadingLatest
{
	/// <summary>
	/// Gets the serial
	/// </summary>
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Gets the sensor reading network
	/// </summary>
	[DataMember(Name = "network")]
	public SensorReadingNetwork SensorReadingNetwork { get; set; } = new();

	/// <summary>
	/// Gets the readings
	/// </summary>
	[DataMember(Name = "readings")]
	public List<SensorReadingLatestReading> Readings { get; set; } = [];
}
