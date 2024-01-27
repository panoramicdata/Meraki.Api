namespace Meraki.Api.Data;

/// <summary>
/// Wireless Ethernet Ports Profile Port
/// </summary>
[DataContract]
public class WirelessEthernetPortsProfilePort
{
	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// Number
	/// </summary>
	[DataMember(Name = "number")]
	public int? Number { get; set; }

	/// <summary>
	/// Enabled
	/// </summary>
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// Ssid
	/// </summary>
	[DataMember(Name = "ssid")]
	public int? Ssid { get; set; }

	/// <summary>
	/// PSK Group Id
	/// </summary>
	[DataMember(Name = "pskGroupId")]
	public string? PskGroupId { get; set; }
}