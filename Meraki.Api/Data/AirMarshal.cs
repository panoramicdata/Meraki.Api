namespace Meraki.Api.Data;

/// <summary>
/// Network air marshal
/// </summary>
[DataContract]
public class AirMarshal
{
	/// <summary>
	/// SSID
	/// </summary>
	[DataMember(Name = "ssid")]
	public string Ssid { get; set; } = string.Empty;

	/// <summary>
	/// BSSIDS
	/// </summary>
	[DataMember(Name = "bssids")]
	public List<Bssids> Bssids { get; set; } = new();

	/// <summary>
	/// Channels
	/// </summary>
	[DataMember(Name = "channels")]
	public List<int> Channels { get; set; } = new();

	/// <summary>
	/// First seen
	/// </summary>
	[DataMember(Name = "firstSeen")]
	public int FirstSeen { get; set; }

	/// <summary>
	/// Last seen
	/// </summary>
	[DataMember(Name = "lastSeen")]
	public int LastSeen { get; set; }

	/// <summary>
	/// Wired macs
	/// </summary>
	[DataMember(Name = "wiredMacs")]
	public List<string> WiredMacs { get; set; } = new();

	/// <summary>
	/// Wired vlans
	/// </summary>
	[DataMember(Name = "wiredVlans")]
	public List<int> WiredVlans { get; set; } = new();

	/// <summary>
	/// Wired last seen
	/// </summary>
	[DataMember(Name = "wiredLastSeen")]
	public int WiredLastSeen { get; set; }
}
