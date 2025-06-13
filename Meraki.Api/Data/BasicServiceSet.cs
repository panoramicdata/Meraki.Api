namespace Meraki.Api.Data;

/// <summary>
/// Basic service sets
/// </summary>
[DataContract]
public class BasicServiceSet
{
	/// <summary>
	/// SSID name
	/// </summary>
	[DataMember(Name = "ssidName")]
	public string SsidName { get; set; } = string.Empty;

	/// <summary>
	/// SSID number
	/// </summary>
	[DataMember(Name = "ssidNumber")]
	public int SsidNumber { get; set; }

	/// <summary>
	/// Enabled
	/// </summary>
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	/// <summary>
	/// Band
	/// </summary>
	[DataMember(Name = "band")]
	public string Band { get; set; } = string.Empty;

	/// <summary>
	/// BSSID
	/// </summary>
	[DataMember(Name = "bssid")]
	public BasicServiceSetBssid Bssid { get; set; } = new();

	/// <summary>
	/// Channel
	/// </summary>
	[DataMember(Name = "channel")]
	public int Channel { get; set; }

	/// <summary>
	/// Channel width
	/// </summary>
	[DataMember(Name = "channelWidth")]
	public string ChannelWidth { get; set; } = string.Empty;

	/// <summary>
	/// Power
	/// </summary>
	[DataMember(Name = "power")]
	public string Power { get; set; } = string.Empty;

	/// <summary>
	/// Visible
	/// </summary>
	[DataMember(Name = "visible")]
	public bool Visible { get; set; }

	/// <summary>
	/// Broadcasting
	/// </summary>
	[DataMember(Name = "broadcasting")]
	public bool Broadcasting { get; set; }
}
