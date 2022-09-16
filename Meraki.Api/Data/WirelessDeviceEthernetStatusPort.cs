namespace Meraki.Api.Data;

/// <summary>
/// Wireless Device Ethernet Status Port Details
/// </summary>
[DataContract]
public class WirelessDeviceEthernetStatusPort : NamedItem
{
	/// <summary>
	/// Link Negotiation object for the port
	/// </summary>
	[DataMember(Name = "linkNegotiation")]
	public WirelessDeviceEthernetStatusPortLinkNegotiation LinkNegotiation { get; set; } = new();

	/// <summary>
	/// PoE details object for the port
	/// </summary>
	[DataMember(Name = "poe")]
	public WirelessDeviceEthernetStatusPortPoe Poe { get; set; } = new();
}
