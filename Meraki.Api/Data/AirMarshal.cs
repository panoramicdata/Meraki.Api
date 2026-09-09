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
	public List<Bssids> Bssids { get; set; } = [];

	/// <summary>
	/// Channels
	/// </summary>
	[DataMember(Name = "channels")]
	public List<int> Channels { get; set; } = [];

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
	public List<string> WiredMacs { get; set; } = [];

	/// <summary>
	/// Wired vlans
	/// </summary>
	[DataMember(Name = "wiredVlans")]
	public List<int> WiredVlans { get; set; } = [];

	/// <summary>
	/// Wired last seen
	/// </summary>
	[DataMember(Name = "wiredLastSeen")]
	public int WiredLastSeen { get; set; }

	/// <summary>
	/// High-level encryption mode observed for the SSID ('WEP', 'WPA' or 'open'); null when it cannot be inferred
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "encryption")]
	public string? Encryption { get; set; }

	/// <summary>
	/// Vendor names resolved from the OUI of each broadcasting BSSID (not the OUI hex prefix itself)
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "manufacturers")]
	public List<string>? Manufacturers { get; set; }

	/// <summary>
	/// Threat classifications applied to this SSID, for example 'rogue', 'spoof', 'other', 'neighbor'
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "types")]
	public List<string>? Types { get; set; }
}
