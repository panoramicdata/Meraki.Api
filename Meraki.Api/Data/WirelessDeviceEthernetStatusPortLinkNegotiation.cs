namespace Meraki.Api.Data;

/// <summary>
/// Wireless Device Ethernet Status Port Link Negotiation Details
/// </summary>
[DataContract]
public class WirelessDeviceEthernetStatusPortLinkNegotiation
{
	/// <summary>
	/// The speed of the port
	/// </summary>
	[DataMember(Name = "speed")]
	public int Speed { get; set; }

	/// <summary>
	/// The duplex mode of the port, can be 'full' or 'half'
	/// </summary>
	[DataMember(Name = "duplex")]
	public WirelessDeviceEthernetStatusPortLinkNegotiationDuplex duplex { get; set; }
}
