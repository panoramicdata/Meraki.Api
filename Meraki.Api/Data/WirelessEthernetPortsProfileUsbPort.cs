namespace Meraki.Api.Data;

/// <summary>
/// Wireless Ethernet Ports Profile Port
/// </summary>
[DataContract]
public class WirelessEthernetPortsProfileUsbPort
{
	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }

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
}
