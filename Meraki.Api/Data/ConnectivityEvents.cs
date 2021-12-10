namespace Meraki.Api.Data;

/// <summary>
/// Connectivity events
/// </summary>
[DataContract]
public class ConnectivityEvents
{
	/// <summary>
	/// Occured at
	/// </summary>
	[DataMember(Name = "occuredAt")]
	public DateTime OccuredAt { get; set; }

	/// <summary>
	/// Device serial
	/// </summary>
	[DataMember(Name = "deviceSerial")]
	public string DeviceSerial { get; set; } = string.Empty;

	/// <summary>
	/// Band
	/// </summary>
	[DataMember(Name = "band")]
	public int Band { get; set; }

	/// <summary>
	/// Ssid
	/// </summary>
	[DataMember(Name = "ssid")]
	public int Ssid { get; set; }

	/// <summary>
	/// Type
	/// </summary>
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// Subtype
	/// </summary>
	[DataMember(Name = "subtype")]
	public string Subtype { get; set; } = string.Empty;

	/// <summary>
	/// Severity
	/// </summary>
	[DataMember(Name = "severity")]
	public string Severity { get; set; } = string.Empty;

	/// <summary>
	/// Duration
	/// </summary>
	[DataMember(Name = "durationMs")]
	public int DurationMs { get; set; }

	/// <summary>
	/// Channel
	/// </summary>
	[DataMember(Name = "channel")]
	public int Channel { get; set; }

	/// <summary>
	/// Rssi
	/// </summary>
	[DataMember(Name = "rssi")]
	public int Rssi { get; set; }

	/// <summary>
	/// Event data
	/// </summary>
	[DataMember(Name = "eventData")]
	public EventData EventData { get; set; } = new();
}
